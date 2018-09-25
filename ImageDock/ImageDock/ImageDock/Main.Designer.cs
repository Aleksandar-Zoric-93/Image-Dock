namespace ImageDock
{
    partial class mainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFrm));
            this.uploadBtn = new System.Windows.Forms.PictureBox();
            this.uploadLbl = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.widthTxt = new System.Windows.Forms.NumericUpDown();
            this.heightTxt = new System.Windows.Forms.NumericUpDown();
            this.widthLbl = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.iconsLbl = new System.Windows.Forms.Label();
            this.formatTxt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveLocBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uploadBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uploadBtn.BackgroundImage")));
            this.uploadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.uploadBtn.Location = new System.Drawing.Point(230, 62);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(70, 66);
            this.uploadBtn.TabIndex = 0;
            this.uploadBtn.TabStop = false;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // uploadLbl
            // 
            this.uploadLbl.AutoSize = true;
            this.uploadLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadLbl.Location = new System.Drawing.Point(143, 140);
            this.uploadLbl.Name = "uploadLbl";
            this.uploadLbl.Size = new System.Drawing.Size(249, 25);
            this.uploadLbl.TabIndex = 1;
            this.uploadLbl.Text = "Upload an image to convert";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(15, 265);
            this.widthTxt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(120, 20);
            this.widthTxt.TabIndex = 4;
            // 
            // heightTxt
            // 
            this.heightTxt.Location = new System.Drawing.Point(168, 265);
            this.heightTxt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightTxt.Name = "heightTxt";
            this.heightTxt.Size = new System.Drawing.Size(120, 20);
            this.heightTxt.TabIndex = 5;
            // 
            // widthLbl
            // 
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(13, 249);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(68, 13);
            this.widthLbl.TabIndex = 6;
            this.widthLbl.Text = "Select Width";
            // 
            // heightLbl
            // 
            this.heightLbl.AutoSize = true;
            this.heightLbl.Location = new System.Drawing.Point(165, 249);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(71, 13);
            this.heightLbl.TabIndex = 7;
            this.heightLbl.Text = "Select Height";
            // 
            // iconsLbl
            // 
            this.iconsLbl.AutoSize = true;
            this.iconsLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iconsLbl.Location = new System.Drawing.Point(4, 292);
            this.iconsLbl.Name = "iconsLbl";
            this.iconsLbl.Size = new System.Drawing.Size(108, 13);
            this.iconsLbl.TabIndex = 8;
            this.iconsLbl.Text = "Icons by SmashIcons";
            // 
            // formatTxt
            // 
            this.formatTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formatTxt.FormattingEnabled = true;
            this.formatTxt.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "JPG",
            "BMP",
            "TIF",
            "TIFF",
            "GIF",
            "EPS"});
            this.formatTxt.Location = new System.Drawing.Point(304, 265);
            this.formatTxt.Name = "formatTxt";
            this.formatTxt.Size = new System.Drawing.Size(100, 21);
            this.formatTxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Image Format";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Save Location";
            // 
            // saveLocBtn
            // 
            this.saveLocBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveLocBtn.Location = new System.Drawing.Point(437, 265);
            this.saveLocBtn.Name = "saveLocBtn";
            this.saveLocBtn.Size = new System.Drawing.Size(75, 23);
            this.saveLocBtn.TabIndex = 12;
            this.saveLocBtn.Text = "Select";
            this.saveLocBtn.UseVisualStyleBackColor = true;
            this.saveLocBtn.Click += new System.EventHandler(this.saveLocBtn_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 307);
            this.Controls.Add(this.saveLocBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formatTxt);
            this.Controls.Add(this.iconsLbl);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.widthLbl);
            this.Controls.Add(this.heightTxt);
            this.Controls.Add(this.widthTxt);
            this.Controls.Add(this.uploadLbl);
            this.Controls.Add(this.uploadBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Dock";
            ((System.ComponentModel.ISupportInitialize)(this.uploadBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox uploadBtn;
        private System.Windows.Forms.Label uploadLbl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.NumericUpDown widthTxt;
        private System.Windows.Forms.NumericUpDown heightTxt;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label heightLbl;
        private System.Windows.Forms.Label iconsLbl;
        private System.Windows.Forms.ComboBox formatTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveLocBtn;

    }
}

