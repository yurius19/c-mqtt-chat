using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//M2Mqtt Library
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace Chat_mqtt
{
    public partial class Form1 : Form
    {
        MqttClient client;
        string clientId;
        delegate void SetTextCallback(string text);
        delegate void SetImageCallback(Image img);
        string base64String;
        Image img;
        int index=1;

        public Form1()
        {
            InitializeComponent();
            string BrokerAddress = "127.0.0.1";

            client = new MqttClient(BrokerAddress);

            client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(EventPublished);
            //RichTextBox1.BackColor = System.Drawing.SystemColors.Window;
            Bdisconnect.Enabled = false;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Chat", -2, HorizontalAlignment.Left);
            listView2.Columns.Add("Immagini", -2, HorizontalAlignment.Left);
            //ImageList Imagelist = new ImageList();
 

        }

        private void EventPublished(Object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            Image image;
            try
            {
                String msg = System.Text.UTF8Encoding.UTF8.GetString(e.Message);
                if (msg.StartsWith("[")){
                    SetText(msg);
                }
                else
                {
                    Console.WriteLine(msg);
                    byte[] imageBytes = Convert.FromBase64String(msg);
                    using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                    {
                        image = Image.FromStream(ms, true);
                    }
                    SetImage(image);
                }

                /*Char delimiter = '*';
                String[] substrings = msg.Split(delimiter);
                foreach (var substring in substrings)
                    Console.WriteLine(substring);*/

            }
            catch (InvalidCastException ex)
            {
            }
        }

        private void SetImage(Image img)
        {
            int i = 0;
            if (this.listView2.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetImage);
                this.Invoke(d, img);
            }
            else
            {
               
                ImageList Imagelist = new ImageList();
                Imagelist.Images.Add(img);
                Imagelist.ImageSize = new Size(96, 96);
                Imagelist.ColorDepth = ColorDepth.Depth32Bit;
                listView2.LargeImageList = Imagelist;
                listView2.SmallImageList = Imagelist;
                //Random rnd = new Random();
                // int month = rnd.Next(1, 13);
                //listView1.Items.Add(new ListViewItem { ImageIndex = 0, Text = "Image " + month });
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                listView2.Items.Add(item);
                listView2.Items[listView2.Items.Count - 1].EnsureVisible();
                i++;
                //dataGridView1.Rows.Add();
                //dataGridView1.Rows[index].Cells[1].Value = img;
                //aggiungere anche chi l'ha mandata?
                //index++;

            }
        }


        private void SetText(string text)
        {
            if (this.listView1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                ListViewItem itm;
                //string[] arr = new string[2];
                //arr[0] = text;
                //arr[1] = "Nessuna Immagine";
                itm = new ListViewItem(text);               
                ListViewItem itmprova = new ListViewItem(text);
                listView1.Items.Add(itmprova);
                listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                //dataGridView1.Rows.Add();
                //dataGridView1.Rows[index].Cells[0].Value = text;
            }
        }

        private void Bpublish_Click(object sender, EventArgs e)
        {
            //String nick;
            //nick = Tnickname.Text;
            String ora;
            try
            {
                ora = DateTime.Now.ToString("h:mm:ss");    
                client.Publish(Ttopic.Text, Encoding.UTF8.GetBytes("[" + ora + "]" + Tnickname.Text + ": " + Tmessage.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                
                //listChat.Items.Add("*** Publishing on: " + Ttopic.Text);
                Tmessage.Clear();
                
            }
            catch (InvalidCastException ex)
            {
            }
        }

        private void Bconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // use a unique id as client id, each time we start the application
                clientId = Guid.NewGuid().ToString();//generazione id?
                client.Connect(clientId);
                
                var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
                if (regexItem.IsMatch(Tnickname.Text))
                {
                    Tnickname.ReadOnly = true;
                    Ttopic.ReadOnly = true;
                    ListViewItem itm;
                    itm = new ListViewItem("* Client connected\n");
                    listView1.Items.Add(itm);
                    //dataGridView1.Rows.Add();
                    //dataGridView1.Rows[index].Cells[0].Value = "* Client connected";
                    index++;
                    client.Subscribe(new string[] { Ttopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    itm = new ListViewItem(" * *Subscribing to: " + Ttopic.Text+"\n");
                    listView1.Items.Add(itm);
                    //dataGridView1.Rows.Add();
                    ///dataGridView1.Rows[index].Cells[0].Value = " * *Subscribing to: " + Ttopic.Text;
                    //index++;
                    Bconnect.Enabled = false;
                    Bdisconnect.Enabled = true;
                    listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                }
                else
                {
                    LErrorNickname.Text=("Il Nickname contiene dei caratteri non validi!");
                }

            }
            catch (InvalidCastException ex)
            {
            }
        }

        private void Bdisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            ListViewItem itm = new ListViewItem(" * Client disconnected\n");
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[index].Cells[0].Value = " * Client disconnected";
            //index++;
            Tnickname.ReadOnly = false;
            Ttopic.ReadOnly = false;
            Bconnect.Enabled = true;
            Bdisconnect.Enabled = false;
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();

        }

        private void b_allega_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                using (Image image = Image.FromFile(path))
                 {
                     using (MemoryStream m = new MemoryStream())
                     {
                         image.Save(m, image.RawFormat);
                         byte[] imageBytes = m.ToArray();

                         // Convert byte[] to Base64 String
                         base64String = Convert.ToBase64String(imageBytes);
                         Console.WriteLine(base64String);
                         client.Publish(Ttopic.Text, Encoding.UTF8.GetBytes(base64String), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                     }
                 }

                //set image
                /*ImageList Imagelist = new ImageList();
                Imagelist.Images.Add(Image.FromFile(path));
                Imagelist.ImageSize = new Size(128, 128);
                Imagelist.ColorDepth = ColorDepth.Depth32Bit;

               
                listView1.LargeImageList = Imagelist;
                listView1.SmallImageList = Imagelist;
                Random rnd = new Random();
                int month = rnd.Next(1, 13);
                listView1.Items.Add(new ListViewItem { ImageIndex = 0, Text = "Image "+month });
                listView1.Items[listView1.Items.Count - 1].EnsureVisible();*/
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
