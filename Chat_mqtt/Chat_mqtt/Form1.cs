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

        public Form1()
        {
            InitializeComponent();
            string BrokerAddress = "127.0.0.1";

            client = new MqttClient(BrokerAddress);

            client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(EventPublished);
            RichTextBox1.ReadOnly = true;
            RichTextBox1.BackColor = System.Drawing.SystemColors.Window;
            Bdisconnect.Enabled = false;

        }

        private void EventPublished(Object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            try
            {
                //SetText("*** Received Message");
                //SetText("*** Topic: " + e.Topic);
                String msg = System.Text.UTF8Encoding.UTF8.GetString(e.Message);
                Char delimiter = '*';
                String[] substrings = msg.Split(delimiter);
                foreach (var substring in substrings)
                    Console.WriteLine(substring);
                SetText("[" + substrings[0] + "]" + substrings[1] +": "+substrings[2]);
            }
            catch (InvalidCastException ex)
            {
            }
        }

        private void SetText(string text)
        {
            if (this.RichTextBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.RichTextBox1.AppendText(text+"\n");
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
                    RichTextBox1.AppendText("* Client connected\n");
                    client.Subscribe(new string[] { Ttopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                    RichTextBox1.AppendText("** Subscribing to: " + Ttopic.Text+"\n");
                    Bconnect.Enabled = false;
                    Bdisconnect.Enabled = true;
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
            RichTextBox1.AppendText("*Client disconnected\n");
            Tnickname.ReadOnly = false;
            Ttopic.ReadOnly = false;
            Bconnect.Enabled = true;
            Bdisconnect.Enabled = false;

        }

        private void listChat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tnickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ttopic_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void b_allega_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                Image image = Image.FromFile(path);
                Clipboard.SetDataObject(image);
                //Clipboard.SetImage(image);
                RichTextBox1.AppendText(path+"\n");
                DataFormats.Format dataFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                if (RichTextBox1.CanPaste(dataFormat))
                {
                    
                    RichTextBox1.Paste(dataFormat);
                    RichTextBox1.AppendText("prova immagine\n");
                    
                }
                else
                    RichTextBox1.AppendText("niente da fare\n");
                //RichTextBox1.Paste();
                //RichTextBox1.AppendText("\n");
                //listView.Items.Add(path);
                //this.img = Image.FromFile(path);
                //byte[] img= Convertitore(this.img);
                //RichTextBox1.(img);
            }

        }
        private byte[] Convertitore(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void listChat_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tmessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
