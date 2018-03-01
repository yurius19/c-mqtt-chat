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
using BrightIdeasSoftware;

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
            objectListView1.ShowGroups = false;
            this.objectListView1.SetObjects(Chat.get());
            string BrokerAddress = "127.0.0.1";

            client = new MqttClient(BrokerAddress);

            client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(EventPublished);
            Bdisconnect.Enabled = false;

            //objectListView1.View = View.Details;
            



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

            }
            catch (InvalidCastException ex)
            {
            }
        }

        private void SetImage(Image img)
        {
            int i = 0;
            if (this.objectListView1.InvokeRequired)
            {
                SetImageCallback d = new SetImageCallback(SetImage);
                this.Invoke(d, img);
            }
            else
            {
                Chat obj = new Chat("hai inviato:", img);
                objectListView1.AddObject(obj);

            }
        }


        private void SetText(string text)
        {
            if (this.objectListView1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                Chat obj = new Chat(text, null);
                objectListView1.AddObject(obj);
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
                    Chat obj = new Chat("Connected \n", img);
                    objectListView1.AddObject(obj);
                    //dataGridView1.Rows.Add();
                    //dataGridView1.Rows[index].Cells[0].Value = "* Client connected";
                    index++;
                    client.Subscribe(new string[] { Ttopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    Chat obj1 = new Chat("Subscribing to: " + Ttopic.Text + "\n",null);
                    objectListView1.AddObject(obj1);
                    //dataGridView1.Rows.Add();
                    ///dataGridView1.Rows[index].Cells[0].Value = " * *Subscribing to: " + Ttopic.Text;
                    //index++;
                    Bconnect.Enabled = false;
                    Bdisconnect.Enabled = true;
                    //listView1.Items[listView1.Items.Count - 1].EnsureVisible();
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
            Chat obj1 = new Chat("Disconnected\nn", null);
            objectListView1.AddObject(obj1);
            //dataGridView1.Rows.Add();
            //dataGridView1.Rows[index].Cells[0].Value = " * Client disconnected";
            //index++;
            Tnickname.ReadOnly = false;
            Ttopic.ReadOnly = false;
            Bconnect.Enabled = true;
            Bdisconnect.Enabled = false;
            //listView1.Items[listView1.Items.Count - 1].EnsureVisible();

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
