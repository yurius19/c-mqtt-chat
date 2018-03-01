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
            this.LErrorNickname = new System.Windows.Forms.Label();
            this.b_allega = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.Testo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Immagini = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bpublish
            // 
            this.Bpublish.Location = new System.Drawing.Point(829, 364);
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
            this.Lmessage.Location = new System.Drawing.Point(11, 349);
            this.Lmessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lmessage.Name = "Lmessage";
            this.Lmessage.Size = new System.Drawing.Size(77, 13);
            this.Lmessage.TabIndex = 3;
            this.Lmessage.Text = "Your message:";
            // 
            // Tmessage
            // 
            this.Tmessage.Location = new System.Drawing.Point(11, 364);
            this.Tmessage.Margin = new System.Windows.Forms.Padding(2);
            this.Tmessage.Multiline = true;
            this.Tmessage.Name = "Tmessage";
            this.Tmessage.Size = new System.Drawing.Size(684, 24);
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
            this.Bconnect.Location = new System.Drawing.Point(9, 64);
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
            this.Bdisconnect.Location = new System.Drawing.Point(68, 66);
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
            this.Lchat.Location = new System.Drawing.Point(271, 4);
            this.Lchat.Name = "Lchat";
            this.Lchat.Size = new System.Drawing.Size(32, 13);
            this.Lchat.TabIndex = 11;
            this.Lchat.Text = "Chat:";
            // 
            // LErrorNickname
            // 
            this.LErrorNickname.AutoSize = true;
            this.LErrorNickname.Location = new System.Drawing.Point(271, 24);
            this.LErrorNickname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LErrorNickname.Name = "LErrorNickname";
            this.LErrorNickname.Size = new System.Drawing.Size(0, 13);
            this.LErrorNickname.TabIndex = 13;
            // 
            // b_allega
            // 
            this.b_allega.Location = new System.Drawing.Point(728, 364);
            this.b_allega.Margin = new System.Windows.Forms.Padding(2);
            this.b_allega.Name = "b_allega";
            this.b_allega.Size = new System.Drawing.Size(67, 23);
            this.b_allega.TabIndex = 12;
            this.b_allega.Text = "Allega";
            this.b_allega.UseVisualStyleBackColor = true;
            this.b_allega.Click += new System.EventHandler(this.b_allega_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.Testo);
            this.objectListView1.AllColumns.Add(this.Immagini);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Testo,
            this.Immagini});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Location = new System.Drawing.Point(276, 24);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(602, 296);
            this.objectListView1.TabIndex = 14;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.SelectedIndexChanged += new System.EventHandler(this.objectListView1_SelectedIndexChanged);
            // 
            // Testo
            // 
            this.Testo.AspectName = "Text";
            this.Testo.CellEditUseWholeCell = false;
            this.Testo.Text = "Text";
            this.Testo.Width = 300;
            // 
            // Immagini
            // 
            this.Immagini.AspectName = "Image";
            this.Immagini.ImageAspectName = "Image";
            this.Immagini.Text = "Immagini";
            this.Immagini.Width = 298;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 431);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.b_allega);
            this.Controls.Add(this.LErrorNickname);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
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
        private System.Windows.Forms.Label LErrorNickname;
        private System.Windows.Forms.Button b_allega;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn Testo;
        private BrightIdeasSoftware.OLVColumn Immagini;
    }
}

