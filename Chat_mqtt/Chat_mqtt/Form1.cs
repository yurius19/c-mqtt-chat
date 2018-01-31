using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
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

        public Form1()
        {
            InitializeComponent();
            string BrokerAddress = "test.mosquitto.org";

            client = new MqttClient(BrokerAddress);

            client.MqttMsgPublishReceived += new MqttClient.MqttMsgPublishEventHandler(EventPublished);
            

        }

        private void EventPublished(Object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            try
            {
                //SetText("*** Received Message");
                //SetText("*** Topic: " + e.Topic);
                SetText("*** Message: " + System.Text.UTF8Encoding.UTF8.GetString(e.Message));
                //SetText("");
            }
            catch (InvalidCastException ex)
            {
            }
        }

        private void SetText(string text)
        {
            if (this.listChat.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.listChat.Items.Add(text);
            }
        }

        private void Bpublish_Click(object sender, EventArgs e)
        {
            try
            {
                client.Publish(Ttopic.Text, Encoding.UTF8.GetBytes(Tmessage.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                //listChat.Items.Add("*** Publishing on: " + Ttopic.Text);
            }
            catch (InvalidCastException ex)
            {
            }
        }

        //connect fa anche subscribe (?)
        private void Bconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // use a unique id as client id, each time we start the application
                clientId = Guid.NewGuid().ToString();//generazione id?
                client.Connect(clientId);
                listChat.Items.Add("* Client connected");
                client.Subscribe(new string[] { Ttopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
                listChat.Items.Add("** Subscribing to: " + Ttopic.Text);
            }
            catch (InvalidCastException ex)
            {
            }
        }

        private void Bdisconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            listChat.Items.Add("*Client disconnected");
        }


    }
}
