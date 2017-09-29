﻿namespace MIPP.Forms
{
    partial class FormImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBackground = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.rbImage = new System.Windows.Forms.RadioButton();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.dgvImage = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.axWMP);
            this.groupBox1.Controls.Add(this.rbVideo);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbDepart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbBackground);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.rbImage);
            this.groupBox1.Controls.Add(this.btnPhoto);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.pbBackground);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 463);
            this.groupBox1.TabIndex = 1020;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tela";
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(6, 70);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(720, 380);
            this.axWMP.TabIndex = 1048;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(148, 19);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(52, 17);
            this.rbVideo.TabIndex = 1037;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            this.rbVideo.CheckedChanged += new System.EventHandler(this.rbVideo_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Location = new System.Drawing.Point(685, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 1036;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbDepart
            // 
            this.cmbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Items.AddRange(new object[] {
            ""});
            this.cmbDepart.Location = new System.Drawing.Point(313, 44);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(45, 21);
            this.cmbDepart.TabIndex = 1035;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1034;
            this.label4.Text = "Depart";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Location = new System.Drawing.Point(593, 18);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 40);
            this.btnUpdate.TabIndex = 1033;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Location = new System.Drawing.Point(639, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 1029;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(547, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 1030;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1032;
            this.label2.Text = "Descrição";
            // 
            // rbBackground
            // 
            this.rbBackground.AutoSize = true;
            this.rbBackground.Location = new System.Drawing.Point(52, 42);
            this.rbBackground.Name = "rbBackground";
            this.rbBackground.Size = new System.Drawing.Size(97, 17);
            this.rbBackground.TabIndex = 1021;
            this.rbBackground.TabStop = true;
            this.rbBackground.Text = "Plano de fundo";
            this.rbBackground.UseVisualStyleBackColor = true;
            this.rbBackground.CheckedChanged += new System.EventHandler(this.rbBackground_CheckedChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(313, 18);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(230, 20);
            this.txtDescription.TabIndex = 1031;
            // 
            // rbImage
            // 
            this.rbImage.AutoSize = true;
            this.rbImage.Location = new System.Drawing.Point(52, 19);
            this.rbImage.Name = "rbImage";
            this.rbImage.Size = new System.Drawing.Size(62, 17);
            this.rbImage.TabIndex = 1020;
            this.rbImage.TabStop = true;
            this.rbImage.Text = "Imagem";
            this.rbImage.UseVisualStyleBackColor = true;
            this.rbImage.CheckedChanged += new System.EventHandler(this.rbImage_CheckedChanged);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhoto.BackgroundImage")));
            this.btnPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPhoto.Location = new System.Drawing.Point(6, 19);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(40, 40);
            this.btnPhoto.TabIndex = 1019;
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.GreenYellow;
            this.pbImage.Location = new System.Drawing.Point(6, 97);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(281, 353);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1018;
            this.pbImage.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.LawnGreen;
            this.pbBackground.Location = new System.Drawing.Point(6, 70);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(720, 380);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 1017;
            this.pbBackground.TabStop = false;
            // 
            // dgvImage
            // 
            this.dgvImage.AllowUserToAddRows = false;
            this.dgvImage.AllowUserToDeleteRows = false;
            this.dgvImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImage.Location = new System.Drawing.Point(750, 12);
            this.dgvImage.Name = "dgvImage";
            this.dgvImage.ReadOnly = true;
            this.dgvImage.Size = new System.Drawing.Size(350, 463);
            this.dgvImage.TabIndex = 2;
            this.dgvImage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImage_CellClick);
            // 
            // FormImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormImage";
            this.Text = "Videos";
            this.Load += new System.EventHandler(this.FormImage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBackground;
        private System.Windows.Forms.RadioButton rbImage;
        internal System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DataGridView dgvImage;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbVideo;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
    }
}