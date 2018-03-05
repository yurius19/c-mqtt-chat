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
            BrightIdeasSoftware.OLVColumn Testo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bpublish = new System.Windows.Forms.Button();
            this.Tmessage = new System.Windows.Forms.TextBox();
            this.Lnickname = new System.Windows.Forms.Label();
            this.Tnickname = new System.Windows.Forms.TextBox();
            this.Bconnect = new System.Windows.Forms.Button();
            this.Ltopic = new System.Windows.Forms.Label();
            this.Ttopic = new System.Windows.Forms.TextBox();
            this.Bdisconnect = new System.Windows.Forms.Button();
            this.LErrorNickname = new System.Windows.Forms.Label();
            this.b_allega = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Images = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.label1 = new System.Windows.Forms.Label();
            Testo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Testo
            // 
            Testo.AspectName = "Text";
            Testo.CellEditUseWholeCell = false;
            Testo.Text = "Text";
            Testo.Width = 800;
            Testo.WordWrap = true;
            // 
            // Bpublish
            // 
            this.Bpublish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bpublish.BackgroundImage")));
            this.Bpublish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bpublish.ForeColor = System.Drawing.Color.Bisque;
            this.Bpublish.Location = new System.Drawing.Point(1487, 608);
            this.Bpublish.Name = "Bpublish";
            this.Bpublish.Size = new System.Drawing.Size(102, 48);
            this.Bpublish.TabIndex = 1;
            this.Bpublish.UseVisualStyleBackColor = true;
            this.Bpublish.Click += new System.EventHandler(this.Bpublish_Click);
            // 
            // Tmessage
            // 
            this.Tmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tmessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Tmessage.Location = new System.Drawing.Point(269, 608);
            this.Tmessage.Multiline = true;
            this.Tmessage.Name = "Tmessage";
            this.Tmessage.Size = new System.Drawing.Size(1103, 46);
            this.Tmessage.TabIndex = 4;
            this.Tmessage.TextChanged += new System.EventHandler(this.Tmessage_TextChanged);
            // 
            // Lnickname
            // 
            this.Lnickname.AutoSize = true;
            this.Lnickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lnickname.Location = new System.Drawing.Point(10, 24);
            this.Lnickname.Name = "Lnickname";
            this.Lnickname.Size = new System.Drawing.Size(105, 25);
            this.Lnickname.TabIndex = 5;
            this.Lnickname.Text = "Nickname:";
            // 
            // Tnickname
            // 
            this.Tnickname.Location = new System.Drawing.Point(121, 21);
            this.Tnickname.Multiline = true;
            this.Tnickname.Name = "Tnickname";
            this.Tnickname.Size = new System.Drawing.Size(140, 29);
            this.Tnickname.TabIndex = 7;
            // 
            // Bconnect
            // 
            this.Bconnect.ForeColor = System.Drawing.Color.Black;
            this.Bconnect.Location = new System.Drawing.Point(10, 94);
            this.Bconnect.Name = "Bconnect";
            this.Bconnect.Size = new System.Drawing.Size(122, 46);
            this.Bconnect.TabIndex = 6;
            this.Bconnect.Text = "Connect";
            this.Bconnect.UseVisualStyleBackColor = true;
            this.Bconnect.Click += new System.EventHandler(this.Bconnect_Click);
            // 
            // Ltopic
            // 
            this.Ltopic.AutoSize = true;
            this.Ltopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltopic.Location = new System.Drawing.Point(13, 55);
            this.Ltopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ltopic.Name = "Ltopic";
            this.Ltopic.Size = new System.Drawing.Size(67, 25);
            this.Ltopic.TabIndex = 8;
            this.Ltopic.Text = "Topic:";
            // 
            // Ttopic
            // 
            this.Ttopic.Location = new System.Drawing.Point(121, 58);
            this.Ttopic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ttopic.Name = "Ttopic";
            this.Ttopic.Size = new System.Drawing.Size(140, 26);
            this.Ttopic.TabIndex = 9;
            // 
            // Bdisconnect
            // 
            this.Bdisconnect.Location = new System.Drawing.Point(139, 94);
            this.Bdisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bdisconnect.Name = "Bdisconnect";
            this.Bdisconnect.Size = new System.Drawing.Size(122, 46);
            this.Bdisconnect.TabIndex = 10;
            this.Bdisconnect.Text = "Quit";
            this.Bdisconnect.UseVisualStyleBackColor = true;
            this.Bdisconnect.Click += new System.EventHandler(this.Bdisconnect_Click);
            // 
            // LErrorNickname
            // 
            this.LErrorNickname.AutoSize = true;
            this.LErrorNickname.Location = new System.Drawing.Point(406, 37);
            this.LErrorNickname.Name = "LErrorNickname";
            this.LErrorNickname.Size = new System.Drawing.Size(0, 20);
            this.LErrorNickname.TabIndex = 13;
            // 
            // b_allega
            // 
            this.b_allega.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_allega.BackgroundImage")));
            this.b_allega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_allega.Location = new System.Drawing.Point(1378, 608);
            this.b_allega.Name = "b_allega";
            this.b_allega.Size = new System.Drawing.Size(103, 48);
            this.b_allega.TabIndex = 12;
            this.b_allega.UseVisualStyleBackColor = true;
            this.b_allega.Click += new System.EventHandler(this.b_allega_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Images
            // 
            this.Images.AspectName = "Image";
            this.Images.ImageAspectName = "Image";
            this.Images.Text = "Immagini";
            this.Images.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Images.Width = 80;
            this.Images.WordWrap = true;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(Testo);
            this.objectListView1.AllColumns.Add(this.Images);
            this.objectListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            Testo,
            this.Images});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectListView1.Location = new System.Drawing.Point(270, 24);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(1321, 575);
            this.objectListView1.TabIndex = 14;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.SelectedIndexChanged += new System.EventHandler(this.objectListView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Your Message:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 704);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.b_allega);
            this.Controls.Add(this.LErrorNickname);
            this.Controls.Add(this.Bdisconnect);
            this.Controls.Add(this.Ttopic);
            this.Controls.Add(this.Ltopic);
            this.Controls.Add(this.Tnickname);
            this.Controls.Add(this.Bconnect);
            this.Controls.Add(this.Lnickname);
            this.Controls.Add(this.Tmessage);
            this.Controls.Add(this.Bpublish);
            this.ForeColor = System.Drawing.Color.Black;
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
        private System.Windows.Forms.TextBox Tmessage;
        private System.Windows.Forms.Label Lnickname;
        private System.Windows.Forms.TextBox Tnickname;
        private System.Windows.Forms.Button Bconnect;
        private System.Windows.Forms.Label Ltopic;
        private System.Windows.Forms.TextBox Ttopic;
        private System.Windows.Forms.Button Bdisconnect;
        private System.Windows.Forms.Label LErrorNickname;
        private System.Windows.Forms.Button b_allega;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private BrightIdeasSoftware.OLVColumn Images;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private System.Windows.Forms.Button Bpublish;
        private System.Windows.Forms.Label label1;
    }
}

