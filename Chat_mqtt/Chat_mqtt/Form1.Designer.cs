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
            this.SuspendLayout();
            // 
            // Bpublish
            // 
            this.Bpublish.Location = new System.Drawing.Point(315, 260);
            this.Bpublish.Margin = new System.Windows.Forms.Padding(2);
            this.Bpublish.Name = "Bpublish";
            this.Bpublish.Size = new System.Drawing.Size(67, 23);
            this.Bpublish.TabIndex = 1;
            this.Bpublish.Text = "Invia";
            this.Bpublish.UseVisualStyleBackColor = true;
            this.Bpublish.Click += new System.EventHandler(this.Bpublish_Click);
            // 
            // Lmessage
            // 
            this.Lmessage.AutoSize = true;
            this.Lmessage.Location = new System.Drawing.Point(8, 94);
            this.Lmessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lmessage.Name = "Lmessage";
            this.Lmessage.Size = new System.Drawing.Size(77, 13);
            this.Lmessage.TabIndex = 3;
            this.Lmessage.Text = "Your message:";
            // 
            // Tmessage
            // 
            this.Tmessage.Location = new System.Drawing.Point(11, 120);
            this.Tmessage.Margin = new System.Windows.Forms.Padding(2);
            this.Tmessage.Multiline = true;
            this.Tmessage.Name = "Tmessage";
            this.Tmessage.Size = new System.Drawing.Size(371, 132);
            this.Tmessage.TabIndex = 4;
            // 
            // Lnickname
            // 
            this.Lnickname.AutoSize = true;
            this.Lnickname.Location = new System.Drawing.Point(8, 6);
            this.Lnickname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lnickname.Name = "Lnickname";
            this.Lnickname.Size = new System.Drawing.Size(58, 13);
            this.Lnickname.TabIndex = 5;
            this.Lnickname.Text = "Nickname:";
            // 
            // Tnickname
            // 
            this.Tnickname.Location = new System.Drawing.Point(67, 4);
            this.Tnickname.Margin = new System.Windows.Forms.Padding(2);
            this.Tnickname.Multiline = true;
            this.Tnickname.Name = "Tnickname";
            this.Tnickname.Size = new System.Drawing.Size(109, 20);
            this.Tnickname.TabIndex = 7;
            // 
            // Bconnect
            // 
            this.Bconnect.Location = new System.Drawing.Point(202, 19);
            this.Bconnect.Margin = new System.Windows.Forms.Padding(2);
            this.Bconnect.Name = "Bconnect";
            this.Bconnect.Size = new System.Drawing.Size(55, 24);
            this.Bconnect.TabIndex = 6;
            this.Bconnect.Text = "Connect";
            this.Bconnect.UseVisualStyleBackColor = true;
            this.Bconnect.Click += new System.EventHandler(this.Bconnect_Click);
            // 
            // Ltopic
            // 
            this.Ltopic.AutoSize = true;
            this.Ltopic.Location = new System.Drawing.Point(8, 43);
            this.Ltopic.Name = "Ltopic";
            this.Ltopic.Size = new System.Drawing.Size(37, 13);
            this.Ltopic.TabIndex = 8;
            this.Ltopic.Text = "Topic:";
            // 
            // Ttopic
            // 
            this.Ttopic.Location = new System.Drawing.Point(67, 40);
            this.Ttopic.Name = "Ttopic";
            this.Ttopic.Size = new System.Drawing.Size(109, 20);
            this.Ttopic.TabIndex = 9;
            // 
            // Bdisconnect
            // 
            this.Bdisconnect.Location = new System.Drawing.Point(814, 260);
            this.Bdisconnect.Name = "Bdisconnect";
            this.Bdisconnect.Size = new System.Drawing.Size(75, 23);
            this.Bdisconnect.TabIndex = 10;
            this.Bdisconnect.Text = "Quit";
            this.Bdisconnect.UseVisualStyleBackColor = true;
            this.Bdisconnect.Click += new System.EventHandler(this.Bdisconnect_Click);
            // 
            // Lchat
            // 
            this.Lchat.AutoSize = true;
            this.Lchat.Location = new System.Drawing.Point(465, 5);
            this.Lchat.Name = "Lchat";
            this.Lchat.Size = new System.Drawing.Size(32, 13);
            this.Lchat.TabIndex = 11;
            this.Lchat.Text = "Chat:";
            // 
            // listChat
            // 
            this.listChat.FormattingEnabled = true;
            this.listChat.Location = new System.Drawing.Point(468, 27);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(420, 225);
            this.listChat.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 309);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

