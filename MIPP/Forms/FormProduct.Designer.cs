namespace MIPP.Forms
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.btnSearchDepart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearchDescription = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepart = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.btnEAN = new System.Windows.Forms.Button();
            this.lblEAN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(5, 26);
            this.mtbID.Mask = "000000000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(65, 20);
            this.mtbID.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(5, 66);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(224, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // cmbDepart
            // 
            this.cmbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Items.AddRange(new object[] {
            ""});
            this.cmbDepart.Location = new System.Drawing.Point(101, 28);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(45, 21);
            this.cmbDepart.TabIndex = 10;
            this.cmbDepart.SelectedIndexChanged += new System.EventHandler(this.CmbDepart_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Depart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descrição";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(516, 9);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(499, 558);
            this.dgvProduct.TabIndex = 1043;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImage_CellClick);
            // 
            // btnSearchID
            // 
            this.btnSearchID.BackgroundImage = global::MIPP.Properties.Resources.MagnifierBlue;
            this.btnSearchID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchID.Location = new System.Drawing.Point(76, 25);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(19, 20);
            this.btnSearchID.TabIndex = 1048;
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // btnSearchDepart
            // 
            this.btnSearchDepart.BackgroundImage = global::MIPP.Properties.Resources.MagnifierBlue;
            this.btnSearchDepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDepart.Location = new System.Drawing.Point(235, 27);
            this.btnSearchDepart.Name = "btnSearchDepart";
            this.btnSearchDepart.Size = new System.Drawing.Size(19, 20);
            this.btnSearchDepart.TabIndex = 1049;
            this.btnSearchDepart.UseVisualStyleBackColor = true;
            this.btnSearchDepart.Click += new System.EventHandler(this.btnSearchDepart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::MIPP.Properties.Resources.ClearButtonSlinBlue;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(142, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(40, 40);
            this.btnClear.TabIndex = 1050;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearchDescription
            // 
            this.btnSearchDescription.BackgroundImage = global::MIPP.Properties.Resources.MagnifierBlue;
            this.btnSearchDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDescription.Location = new System.Drawing.Point(235, 66);
            this.btnSearchDescription.Name = "btnSearchDescription";
            this.btnSearchDescription.Size = new System.Drawing.Size(19, 20);
            this.btnSearchDescription.TabIndex = 1047;
            this.btnSearchDescription.UseVisualStyleBackColor = true;
            this.btnSearchDescription.Click += new System.EventHandler(this.btnSearchDescription_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::MIPP.Properties.Resources.UpdateBlue;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Location = new System.Drawing.Point(51, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 40);
            this.btnUpdate.TabIndex = 1044;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::MIPP.Properties.Resources.DeleteBlue;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(97, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 1045;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::MIPP.Properties.Resources.SaveBlue;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(5, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 1046;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEAN);
            this.groupBox1.Controls.Add(this.btnEAN);
            this.groupBox1.Controls.Add(this.lblEAN);
            this.groupBox1.Controls.Add(this.lblDepart);
            this.groupBox1.Controls.Add(this.mtbID);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnSearchDepart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSearchID);
            this.groupBox1.Controls.Add(this.cmbDepart);
            this.groupBox1.Controls.Add(this.btnSearchDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(262, 140);
            this.groupBox1.TabIndex = 1051;
            this.groupBox1.TabStop = false;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(152, 33);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(13, 13);
            this.lblDepart.TabIndex = 1050;
            this.lblDepart.Text = "_";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPhoto);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(280, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(231, 90);
            this.groupBox2.TabIndex = 1052;
            this.groupBox2.TabStop = false;
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhoto.BackgroundImage")));
            this.btnPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhoto.Location = new System.Drawing.Point(186, 29);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(40, 40);
            this.btnPhoto.TabIndex = 1051;
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.Chartreuse;
            this.pbPhoto.Location = new System.Drawing.Point(3, 10);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(494, 398);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 1053;
            this.pbPhoto.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pbPhoto);
            this.groupBox3.Location = new System.Drawing.Point(9, 153);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(502, 414);
            this.groupBox3.TabIndex = 1054;
            this.groupBox3.TabStop = false;
            // 
            // txtEAN
            // 
            this.txtEAN.Location = new System.Drawing.Point(5, 106);
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(224, 20);
            this.txtEAN.TabIndex = 1051;
            // 
            // btnEAN
            // 
            this.btnEAN.BackgroundImage = global::MIPP.Properties.Resources.MagnifierBlue;
            this.btnEAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEAN.Location = new System.Drawing.Point(235, 106);
            this.btnEAN.Name = "btnEAN";
            this.btnEAN.Size = new System.Drawing.Size(19, 20);
            this.btnEAN.TabIndex = 1053;
            this.btnEAN.UseVisualStyleBackColor = true;
            this.btnEAN.Click += new System.EventHandler(this.btnEAN_Click);
            // 
            // lblEAN
            // 
            this.lblEAN.AutoSize = true;
            this.lblEAN.Location = new System.Drawing.Point(2, 90);
            this.lblEAN.Name = "lblEAN";
            this.lblEAN.Size = new System.Drawing.Size(29, 13);
            this.lblEAN.TabIndex = 1052;
            this.lblEAN.Text = "EAN";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 572);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormProduct";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProduct;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnSearchDescription;
        internal System.Windows.Forms.Button btnSearchID;
        internal System.Windows.Forms.Button btnSearchDepart;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnPhoto;
        private System.Windows.Forms.TextBox txtEAN;
        internal System.Windows.Forms.Button btnEAN;
        private System.Windows.Forms.Label lblEAN;
    }
}