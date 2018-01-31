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
            this.SuspendLayout();
            // 
            // Bpublish
            // 
            this.Bpublish.Location = new System.Drawing.Point(472, 400);
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
            this.Lmessage.Location = new System.Drawing.Point(12, 145);
            this.Lmessage.Name = "Lmessage";
            this.Lmessage.Size = new System.Drawing.Size(116, 20);
            this.Lmessage.TabIndex = 3;
            this.Lmessage.Text = "Your message:";
            // 
            // Tmessage
            // 
            this.Tmessage.Location = new System.Drawing.Point(16, 185);
            this.Tmessage.Multiline = true;
            this.Tmessage.Name = "Tmessage";
            this.Tmessage.Size = new System.Drawing.Size(554, 201);
            this.Tmessage.TabIndex = 4;
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
            this.Tnickname.TextChanged += new System.EventHandler(this.Tnickname_TextChanged);
            // 
            // Bconnect
            // 
            this.Bconnect.Location = new System.Drawing.Point(303, 29);
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
            this.Bdisconnect.Location = new System.Drawing.Point(1221, 400);
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
            this.Lchat.Location = new System.Drawing.Point(698, 8);
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
            this.listChat.Location = new System.Drawing.Point(702, 42);
            this.listChat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(628, 344);
            this.listChat.TabIndex = 12;
            this.listChat.SelectedIndexChanged += new System.EventHandler(this.listChat_SelectedIndexChanged);
            // 
            // LErrorNickname
            // 
            this.LErrorNickname.AutoSize = true;
            this.LErrorNickname.Location = new System.Drawing.Point(407, 37);
            this.LErrorNickname.Name = "LErrorNickname";
            this.LErrorNickname.Size = new System.Drawing.Size(0, 20);
            this.LErrorNickname.TabIndex = 13;
            this.LErrorNickname.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 475);
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
        private System.Windows.Forms.Label LErrorNickname;
    }
}

