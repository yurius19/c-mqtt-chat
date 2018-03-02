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
        String nick;
        //System.DateTime moment = new System.DateTime(); inutile?
        Image img;
        int flagTxtOrImage = 0;

        public Form1()
        {
            InitializeComponent();
            string BrokerAddress = "test.mosquitto.org";

            client = new MqttClient(BrokerAddress);

            client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(EventPublished);
            //RichTextBox1.BackColor = System.Drawing.SystemColors.Window;
            Bdisconnect.Enabled = false;

            listView1.View = View.Details;
            //listView1.GridLines = true;
            //listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Chat", listView1.Width);


        }

        private void EventPublished(Object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            try
            {
                    String msg = System.Text.UTF8Encoding.UTF8.GetString(e.Message);
                    
                    Char delimiter = '*';
                    String[] substrings = msg.Split(delimiter);
                    foreach (var substring in substrings)
                        Console.WriteLine(substring);
                    SetText("[" + substrings[0] + "]" + substrings[1] + ": " + substrings[2]);
               
                
            }
            catch (InvalidCastException ex)
            {
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
                itm = new ListViewItem(text);
                listView1.Items.Add(itm);
                listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                //this.listChat.Items.Add(text);
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
                client.Publish(Ttopic.Text, Encoding.UTF8.GetBytes(ora+'*'+Tnickname.Text+'*'+Tmessage.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
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
                    client.Subscribe(new string[] { Ttopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    itm = new ListViewItem(" * *Subscribing to: " + Ttopic.Text+"\n");
                    listView1.Items.Add(itm);
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
            listView1.Items.Add(itm);
            Tnickname.ReadOnly = false;
            Ttopic.ReadOnly = false;
            Bconnect.Enabled = true;
            Bdisconnect.Enabled = false;
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();

        }

        private void b_allega_Click(object sender, EventArgs e)
        {
            string path, base64String;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                /* using (Image image = Image.FromFile(path))
                 {
                     using (MemoryStream m = new MemoryStream())
                     {
                         image.Save(m, image.RawFormat);
                         byte[] imageBytes = m.ToArray();

                         // Convert byte[] to Base64 String
                         base64String = Convert.ToBase64String(imageBytes);
                         Console.WriteLine(base64String);
                         //client.Publish(Ttopic.Text, Encoding.UTF8.GetBytes(base64String), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                     }
                 }*/
                ImageList Imagelist = new ImageList();
                Imagelist.Images.Add(Image.FromFile(path));
                Imagelist.ImageSize = new Size(128, 128);
                Imagelist.ColorDepth = ColorDepth.Depth32Bit;

               
                listView1.LargeImageList = Imagelist;
                listView1.SmallImageList = Imagelist;
                Random rnd = new Random();
                int month = rnd.Next(1, 13);
                listView1.Items.Add(new ListViewItem { ImageIndex = 0, Text = "Image "+month });
                listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                /*Clipboard.SetDataObject(image);
                //Clipboard.SetImage(image);
                RichTextBox1.AppendText(path+"\n");
                DataFormats.Format dataFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                if (RichTextBox1.CanPaste(dataFormat))
                {
                    
                    RichTextBox1.Paste(dataFormat);
                    RichTextBox1.AppendText("prova immagine\n");
                    
                }
                else
                    RichTextBox1.AppendText("niente da fare\n");*/
                //RichTextBox1.Paste();
                //RichTextBox1.AppendText("\n");
                //listView.Items.Add(path);
                //this.img = Image.FromFile(path);
                //byte[] img= Convertitore(this.img);
                //RichTextBox1.(img);
            }

        }
        /*private byte[] Convertitore(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }*/

    }
    
}
