namespace MIPP.Forms
{
    partial class FormBIPP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepart = new System.Windows.Forms.Label();
            this.mtbID = new System.Windows.Forms.MaskedTextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSearchDepart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.btnSearchDescription = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbShop = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.dgvBIPPEquival = new System.Windows.Forms.DataGridView();
            this.dgvInsertEquival = new System.Windows.Forms.DataGridView();
            this.txtDesEquival = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadGrid = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDesEquival = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBIPPEquival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertEquival)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDepart);
            this.groupBox1.Controls.Add(this.mtbID);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnSearchDepart);
            this.groupBox1.Controls.Add(this.btnSearchID);
            this.groupBox1.Controls.Add(this.btnSearchDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDepart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(221, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(629, 78);
            this.groupBox1.TabIndex = 1055;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(511, 52);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(16, 17);
            this.lblDepart.TabIndex = 1050;
            this.lblDepart.Text = "_";
            // 
            // mtbID
            // 
            this.mtbID.Location = new System.Drawing.Point(87, 20);
            this.mtbID.Margin = new System.Windows.Forms.Padding(4);
            this.mtbID.Mask = "000000000";
            this.mtbID.Name = "mtbID";
            this.mtbID.Size = new System.Drawing.Size(69, 22);
            this.mtbID.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(87, 50);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(286, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // btnSearchDepart
            // 
            this.btnSearchDepart.BackgroundImage = global::MIPP.Properties.Resources.MagnifierBlue;
            this.btnSearchDepart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDepart.Location = new System.Drawing.Point(514, 21);
            this.btnSearchDepart.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDepart.Name = "btnSearchDepart";
            this.btnSearchDepart.Size = new System.Drawing.Size(25, 25);
            this.btnSearchDepart.TabIndex = 1049;
            this.btnSearchDepart.UseVisualStyleBackColor = true;
            this.btnSearchDepart.Click += new System.EventHandler(this.btnSearchDepart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Depart";
            // 
            // btnSearchID
            // 
            this.btnSearchID.BackgroundImage = global::MIPP.Properties.Resources.MagnifierBlue;
            this.btnSearchID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchID.Location = new System.Drawing.Point(164, 19);
            this.btnSearchID.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(25, 25);
            this.btnSearchID.TabIndex = 1048;
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // cmbDepart
            // 
            this.cmbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Items.AddRange(new object[] {
            ""});
            this.cmbDepart.Location = new System.Drawing.Point(444, 48);
            this.cmbDepart.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(59, 24);
            this.cmbDepart.TabIndex = 10;
            this.cmbDepart.SelectedIndexChanged += new System.EventHandler(this.cmbDepart_SelectedIndexChanged);
            // 
            // btnSearchDescription
            // 
            this.btnSearchDescription.BackgroundImage = global::MIPP.Properties.Resources.MagnifierBlue;
            this.btnSearchDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchDescription.Location = new System.Drawing.Point(381, 51);
            this.btnSearchDescription.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDescription.Name = "btnSearchDescription";
            this.btnSearchDescription.Size = new System.Drawing.Size(25, 25);
            this.btnSearchDescription.TabIndex = 1047;
            this.btnSearchDescription.UseVisualStyleBackColor = true;
            this.btnSearchDescription.Click += new System.EventHandler(this.btnSearchDescription_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // lblShop
            // 
            this.lblShop.AutoSize = true;
            this.lblShop.Location = new System.Drawing.Point(74, 40);
            this.lblShop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShop.Name = "lblShop";
            this.lblShop.Size = new System.Drawing.Size(16, 17);
            this.lblShop.TabIndex = 1053;
            this.lblShop.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descrição";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(252, 20);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 1062;
            // 
            // cmbShop
            // 
            this.cmbShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShop.FormattingEnabled = true;
            this.cmbShop.Items.AddRange(new object[] {
            ""});
            this.cmbShop.Location = new System.Drawing.Point(7, 37);
            this.cmbShop.Margin = new System.Windows.Forms.Padding(4);
            this.cmbShop.Name = "cmbShop";
            this.cmbShop.Size = new System.Drawing.Size(59, 24);
            this.cmbShop.TabIndex = 1052;
            this.cmbShop.SelectedIndexChanged += new System.EventHandler(this.cmbShop_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 1061;
            this.label13.Text = "Preço";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProduct);
            this.groupBox3.Controls.Add(this.pbPhoto);
            this.groupBox3.Location = new System.Drawing.Point(13, 95);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(500, 510);
            this.groupBox3.TabIndex = 1056;
            this.groupBox3.TabStop = false;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(4, 10);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(491, 492);
            this.dgvProduct.TabIndex = 1064;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.Chartreuse;
            this.pbPhoto.Location = new System.Drawing.Point(4, 12);
            this.pbPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(491, 490);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 1053;
            this.pbPhoto.TabStop = false;
            // 
            // dgvBIPPEquival
            // 
            this.dgvBIPPEquival.AllowUserToDeleteRows = false;
            this.dgvBIPPEquival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBIPPEquival.Location = new System.Drawing.Point(6, 12);
            this.dgvBIPPEquival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBIPPEquival.Name = "dgvBIPPEquival";
            this.dgvBIPPEquival.ReadOnly = true;
            this.dgvBIPPEquival.RowTemplate.Height = 24;
            this.dgvBIPPEquival.Size = new System.Drawing.Size(496, 192);
            this.dgvBIPPEquival.TabIndex = 1060;
            this.dgvBIPPEquival.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBIPPEquival_CellContentClick);
            // 
            // dgvInsertEquival
            // 
            this.dgvInsertEquival.AllowUserToAddRows = false;
            this.dgvInsertEquival.AllowUserToDeleteRows = false;
            this.dgvInsertEquival.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInsertEquival.Location = new System.Drawing.Point(6, 255);
            this.dgvInsertEquival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInsertEquival.Name = "dgvInsertEquival";
            this.dgvInsertEquival.ReadOnly = true;
            this.dgvInsertEquival.RowTemplate.Height = 24;
            this.dgvInsertEquival.Size = new System.Drawing.Size(496, 244);
            this.dgvInsertEquival.TabIndex = 1068;
            this.dgvInsertEquival.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInsertEquival_CellDoubleClick);
            // 
            // txtDesEquival
            // 
            this.txtDesEquival.Location = new System.Drawing.Point(6, 227);
            this.txtDesEquival.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesEquival.Name = "txtDesEquival";
            this.txtDesEquival.Size = new System.Drawing.Size(394, 22);
            this.txtDesEquival.TabIndex = 1066;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::MIPP.Properties.Resources.GridClosedBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(509, 70);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1071;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadGrid
            // 
            this.btnLoadGrid.BackgroundImage = global::MIPP.Properties.Resources.GridBlue;
            this.btnLoadGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadGrid.Location = new System.Drawing.Point(858, 40);
            this.btnLoadGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadGrid.Name = "btnLoadGrid";
            this.btnLoadGrid.Size = new System.Drawing.Size(50, 50);
            this.btnLoadGrid.TabIndex = 1065;
            this.btnLoadGrid.UseVisualStyleBackColor = true;
            this.btnLoadGrid.Click += new System.EventHandler(this.btnLoadGrid_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundImage = global::MIPP.Properties.Resources.BlueUpButton;
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.Location = new System.Drawing.Point(509, 258);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(50, 50);
            this.btnInsert.TabIndex = 1070;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::MIPP.Properties.Resources.BlueDownButton;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(509, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 1069;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDesEquival
            // 
            this.btnDesEquival.BackgroundImage = global::MIPP.Properties.Resources.MagnifierBlue;
            this.btnDesEquival.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesEquival.Location = new System.Drawing.Point(477, 224);
            this.btnDesEquival.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesEquival.Name = "btnDesEquival";
            this.btnDesEquival.Size = new System.Drawing.Size(25, 25);
            this.btnDesEquival.TabIndex = 1066;
            this.btnDesEquival.UseVisualStyleBackColor = true;
            this.btnDesEquival.Click += new System.EventHandler(this.btnDesEquival_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::MIPP.Properties.Resources.ClearButtonSlinBlue;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Location = new System.Drawing.Point(915, 40);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 1063;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbShop);
            this.groupBox2.Controls.Add(this.lblShop);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 78);
            this.groupBox2.TabIndex = 1072;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loja";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dgvBIPPEquival);
            this.groupBox4.Controls.Add(this.dgvInsertEquival);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtDesEquival);
            this.groupBox4.Controls.Add(this.btnDesEquival);
            this.groupBox4.Controls.Add(this.btnInsert);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Location = new System.Drawing.Point(519, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(567, 510);
            this.groupBox4.TabIndex = 1073;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 1063;
            this.label3.Text = "Busca por descrição";
            // 
            // FormBIPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 616);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLoadGrid);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormBIPP";
            this.Text = "BIPP - Busca Inteligente PegPese";
            this.Load += new System.EventHandler(this.FormBIPP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBIPPEquival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInsertEquival)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.MaskedTextBox mtbID;
        private System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Button btnSearchDepart;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.ComboBox cmbDepart;
        internal System.Windows.Forms.Button btnSearchDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.DataGridView dgvBIPPEquival;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblShop;
        private System.Windows.Forms.ComboBox cmbShop;
        private System.Windows.Forms.Button btnLoadGrid;
        private System.Windows.Forms.DataGridView dgvInsertEquival;
        private System.Windows.Forms.TextBox txtDesEquival;
        internal System.Windows.Forms.Button btnDesEquival;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
    }
}