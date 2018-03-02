using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_mqtt
{   
    class Chat
    {
        string text;
        Image img;
        public Chat(string text, Image img)
        {
            this.text = text;
            this.img = img;
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public Image Image
        {
            get { return img; }
            set { img = value; }
        }

        static internal List<Chat> get()
        {
            Chat item = new Chat("Benvenuto", null);
            List<Chat> x = new List<Chat>();
            return x;
        }

    }
}
