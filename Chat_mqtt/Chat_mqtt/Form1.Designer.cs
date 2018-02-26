namespace Chat_mqtt
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bpublish = new System.Windows.Forms.Button();
            this.Lmessage = new System.Windows.Forms.Label();
            this.Tmessage = new System.Windows.Forms.TextBox();
            this.Lnickname = new System.Windows.Forms.Label();
            this.Tnickname = new System.Windows.Forms.TextBox();
            this.Bconnect = new System.Windows.Forms.Button();
            this.Ltopic = new System.Windows.Forms.Label();
            this.Ttopic = new System.Windows.Forms.TextBox();
            this.Bdisconnect = new System.Windows.Forms.Button();
            this.Lchat = new System.Windows.Forms.Label();
            this.listChat = new System.Windows.Forms.ListBox();
            this.LErrorNickname = new System.Windows.Forms.Label();
            this.b_allega = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Bpublish
            // 
            this.Bpublish.Location = new System.Drawing.Point(940, 470);
            this.Bpublish.Name = "Bpublish";
            this.Bpublish.Size = new System.Drawing.Size(100, 35);
            this.Bpublish.TabIndex = 1;
            this.Bpublish.Text = "Invia";
            this.Bpublish.UseVisualStyleBackColor = true;
            this.Bpublish.Click += new System.EventHandler(this.Bpublish_Click);
            // 
            // Lmessage
            // 
            this.Lmessage.AutoSize = true;
            this.Lmessage.Location = new System.Drawing.Point(12, 394);
            this.Lmessage.Name = "Lmessage";
            this.Lmessage.Size = new System.Drawing.Size(116, 20);
            this.Lmessage.TabIndex = 3;
            this.Lmessage.Text = "Your message:";
            // 
            // Tmessage
            // 
            this.Tmessage.Location = new System.Drawing.Point(16, 428);
            this.Tmessage.Multiline = true;
            this.Tmessage.Name = "Tmessage";
            this.Tmessage.Size = new System.Drawing.Size(1024, 23);
            this.Tmessage.TabIndex = 4;
            this.Tmessage.TextChanged += new System.EventHandler(this.Tmessage_TextChanged);
            // 
            // Lnickname
            // 
            this.Lnickname.AutoSize = true;
            this.Lnickname.Location = new System.Drawing.Point(12, 9);
            this.Lnickname.Name = "Lnickname";
            this.Lnickname.Size = new System.Drawing.Size(83, 20);
            this.Lnickname.TabIndex = 5;
            this.Lnickname.Text = "Nickname:";
            // 
            // Tnickname
            // 
            this.Tnickname.Location = new System.Drawing.Point(100, 6);
            this.Tnickname.Multiline = true;
            this.Tnickname.Name = "Tnickname";
            this.Tnickname.Size = new System.Drawing.Size(162, 29);
            this.Tnickname.TabIndex = 7;
            // 
            // Bconnect
            // 
            this.Bconnect.Location = new System.Drawing.Point(13, 99);
            this.Bconnect.Name = "Bconnect";
            this.Bconnect.Size = new System.Drawing.Size(82, 37);
            this.Bconnect.TabIndex = 6;
            this.Bconnect.Text = "Connect";
            this.Bconnect.UseVisualStyleBackColor = true;
            this.Bconnect.Click += new System.EventHandler(this.Bconnect_Click);
            // 
            // Ltopic
            // 
            this.Ltopic.AutoSize = true;
            this.Ltopic.Location = new System.Drawing.Point(12, 66);
            this.Ltopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ltopic.Name = "Ltopic";
            this.Ltopic.Size = new System.Drawing.Size(51, 20);
            this.Ltopic.TabIndex = 8;
            this.Ltopic.Text = "Topic:";
            // 
            // Ttopic
            // 
            this.Ttopic.Location = new System.Drawing.Point(100, 62);
            this.Ttopic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ttopic.Name = "Ttopic";
            this.Ttopic.Size = new System.Drawing.Size(162, 26);
            this.Ttopic.TabIndex = 9;
            this.Ttopic.TextChanged += new System.EventHandler(this.Ttopic_TextChanged);
            // 
            // Bdisconnect
            // 
            this.Bdisconnect.Location = new System.Drawing.Point(102, 101);
            this.Bdisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bdisconnect.Name = "Bdisconnect";
            this.Bdisconnect.Size = new System.Drawing.Size(112, 35);
            this.Bdisconnect.TabIndex = 10;
            this.Bdisconnect.Text = "Quit";
            this.Bdisconnect.UseVisualStyleBackColor = true;
            this.Bdisconnect.Click += new System.EventHandler(this.Bdisconnect_Click);
            // 
            // Lchat
            // 
            this.Lchat.AutoSize = true;
            this.Lchat.Location = new System.Drawing.Point(408, 6);
            this.Lchat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lchat.Name = "Lchat";
            this.Lchat.Size = new System.Drawing.Size(47, 20);
            this.Lchat.TabIndex = 11;
            this.Lchat.Text = "Chat:";
            // 
            // listChat
            // 
            this.listChat.FormattingEnabled = true;
            this.listChat.ItemHeight = 20;
            this.listChat.Location = new System.Drawing.Point(412, 31);
            this.listChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(628, 344);
            this.listChat.TabIndex = 12;
            this.listChat.SelectedIndexChanged += new System.EventHandler(this.listChat_SelectedIndexChanged_1);
            // 
            // LErrorNickname
            // 
            this.LErrorNickname.AutoSize = true;
            this.LErrorNickname.Location = new System.Drawing.Point(407, 37);
            this.LErrorNickname.Name = "LErrorNickname";
            this.LErrorNickname.Size = new System.Drawing.Size(0, 20);
            this.LErrorNickname.TabIndex = 13;
            // 
            // b_allega
            // 
            this.b_allega.Location = new System.Drawing.Point(834, 470);
            this.b_allega.Name = "b_allega";
            this.b_allega.Size = new System.Drawing.Size(100, 35);
            this.b_allega.TabIndex = 12;
            this.b_allega.Text = "Allega";
            this.b_allega.UseVisualStyleBackColor = true;
            this.b_allega.Click += new System.EventHandler(this.b_allega_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Location = new System.Drawing.Point(269, 8);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(132, 129);
            this.RichTextBox1.TabIndex = 14;
            this.RichTextBox1.Text = "";
            this.RichTextBox1.KeyDown += RichTextBox1_KeyDown;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(269, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(138, 150);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 529);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.b_allega);
            this.Controls.Add(this.LErrorNickname);
            this.Controls.Add(this.listChat);
            this.Controls.Add(this.Lchat);
            this.Controls.Add(this.Bdisconnect);
            this.Controls.Add(this.Ttopic);
            this.Controls.Add(this.Ltopic);
            this.Controls.Add(this.Tnickname);
            this.Controls.Add(this.Bconnect);
            this.Controls.Add(this.Lnickname);
            this.Controls.Add(this.Tmessage);
            this.Controls.Add(this.Lmessage);
            this.Controls.Add(this.Bpublish);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void RichTextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            e.Handled = true;
        }
        #endregion
        private System.Windows.Forms.Button Bpublish;
        private System.Windows.Forms.Label Lmessage;
        private System.Windows.Forms.TextBox Tmessage;
        private System.Windows.Forms.Label Lnickname;
        private System.Windows.Forms.TextBox Tnickname;
        private System.Windows.Forms.Button Bconnect;
        private System.Windows.Forms.Label Ltopic;
        private System.Windows.Forms.TextBox Ttopic;
        private System.Windows.Forms.Button Bdisconnect;
        private System.Windows.Forms.Label Lchat;
        private System.Windows.Forms.ListBox listChat;
        private System.Windows.Forms.Label LErrorNickname;
        private System.Windows.Forms.Button b_allega;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox RichTextBox1;
        private System.Windows.Forms.ListView listView1;
    }
}

