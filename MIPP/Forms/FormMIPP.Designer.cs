namespace MIPP
{
    partial class FormMIPP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMIPP));
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbScreen = new System.Windows.Forms.ComboBox();
            this.cmbLoja = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepart = new System.Windows.Forms.Label();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.dgvProdScreen = new System.Windows.Forms.DataGridView();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.pbScreen = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPhoto = new System.Windows.Forms.CheckBox();
            this.cbVideo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnListColor = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbTimer = new System.Windows.Forms.MaskedTextBox();
            this.btnPromoListColor = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPhoto = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvImage = new System.Windows.Forms.DataGridView();
            this.btnSeeBack = new System.Windows.Forms.Button();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnInsertP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnUpProd = new System.Windows.Forms.Button();
            this.btnDownProd = new System.Windows.Forms.Button();
            this.btnPriceUpdate = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProd
            // 
            this.dgvProd.AllowUserToAddRows = false;
            this.dgvProd.AllowUserToDeleteRows = false;
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(8, 85);
            this.dgvProd.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.ReadOnly = true;
            this.dgvProd.Size = new System.Drawing.Size(587, 534);
            this.dgvProd.TabIndex = 0;
            this.toolTip.SetToolTip(this.dgvProd, "Duplo click para adicionar um produto na tela");
            this.dgvProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tela";
            // 
            // cmbScreen
            // 
            this.cmbScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScreen.FormattingEnabled = true;
            this.cmbScreen.Items.AddRange(new object[] {
            ""});
            this.cmbScreen.Location = new System.Drawing.Point(61, 82);
            this.cmbScreen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbScreen.Name = "cmbScreen";
            this.cmbScreen.Size = new System.Drawing.Size(59, 24);
            this.cmbScreen.TabIndex = 4;
            // 
            // cmbLoja
            // 
            this.cmbLoja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoja.FormattingEnabled = true;
            this.cmbLoja.Items.AddRange(new object[] {
            ""});
            this.cmbLoja.Location = new System.Drawing.Point(61, 18);
            this.cmbLoja.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoja.Name = "cmbLoja";
            this.cmbLoja.Size = new System.Drawing.Size(59, 24);
            this.cmbLoja.TabIndex = 5;
            this.cmbLoja.SelectedIndexChanged += new System.EventHandler(this.cmbLoja_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Loja";
            // 
            // cmbDepart
            // 
            this.cmbDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Items.AddRange(new object[] {
            ""});
            this.cmbDepart.Location = new System.Drawing.Point(61, 50);
            this.cmbDepart.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(59, 24);
            this.cmbDepart.TabIndex = 8;
            this.cmbDepart.SelectedIndexChanged += new System.EventHandler(this.cmbDepart_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Depart";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDepart);
            this.groupBox1.Controls.Add(this.axWMP);
            this.groupBox1.Controls.Add(this.gbScreen);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.btnPhoto);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbScreen);
            this.groupBox1.Controls.Add(this.cmbDepart);
            this.groupBox1.Controls.Add(this.cmbLoja);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1016, 634);
            this.groupBox1.TabIndex = 1019;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tela";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(128, 53);
            this.lblDepart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(16, 17);
            this.lblDepart.TabIndex = 1052;
            this.lblDepart.Text = "_";
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.dgvProdScreen);
            this.gbScreen.Controls.Add(this.pbScreen);
            this.gbScreen.Controls.Add(this.pbBackground);
            this.gbScreen.Location = new System.Drawing.Point(8, 128);
            this.gbScreen.Margin = new System.Windows.Forms.Padding(4);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Padding = new System.Windows.Forms.Padding(4);
            this.gbScreen.Size = new System.Drawing.Size(991, 500);
            this.gbScreen.TabIndex = 1040;
            this.gbScreen.TabStop = false;
            // 
            // dgvProdScreen
            // 
            this.dgvProdScreen.AllowUserToAddRows = false;
            this.dgvProdScreen.AllowUserToDeleteRows = false;
            this.dgvProdScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdScreen.Location = new System.Drawing.Point(387, 79);
            this.dgvProdScreen.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdScreen.Name = "dgvProdScreen";
            this.dgvProdScreen.ReadOnly = true;
            this.dgvProdScreen.Size = new System.Drawing.Size(587, 405);
            this.dgvProdScreen.TabIndex = 1043;
            this.toolTip.SetToolTip(this.dgvProdScreen, "Duplo click para remover o produto da tela");
            this.dgvProdScreen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdScreen_CellDoubleClick);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(8, 137);
            this.axWMP.Margin = new System.Windows.Forms.Padding(4);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(720, 380);
            this.axWMP.TabIndex = 1045;
            // 
            // pbScreen
            // 
            this.pbScreen.BackColor = System.Drawing.Color.GreenYellow;
            this.pbScreen.Location = new System.Drawing.Point(13, 50);
            this.pbScreen.Margin = new System.Windows.Forms.Padding(4);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(375, 434);
            this.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScreen.TabIndex = 1041;
            this.pbScreen.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.Chartreuse;
            this.pbBackground.Location = new System.Drawing.Point(13, 17);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(4);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(960, 468);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 1017;
            this.pbBackground.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbPhoto);
            this.groupBox3.Controls.Add(this.cbVideo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnListColor);
            this.groupBox3.Controls.Add(this.btnTimer);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mtbTimer);
            this.groupBox3.Controls.Add(this.btnPromoListColor);
            this.groupBox3.Location = new System.Drawing.Point(430, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(569, 111);
            this.groupBox3.TabIndex = 1039;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configurações da tela";
            // 
            // cbPhoto
            // 
            this.cbPhoto.AutoSize = true;
            this.cbPhoto.Location = new System.Drawing.Point(13, 46);
            this.cbPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.cbPhoto.Name = "cbPhoto";
            this.cbPhoto.Size = new System.Drawing.Size(210, 21);
            this.cbPhoto.TabIndex = 1040;
            this.cbPhoto.Text = "Definir como tela de anuncio";
            this.cbPhoto.UseVisualStyleBackColor = true;
            this.cbPhoto.CheckedChanged += new System.EventHandler(this.cbPhoto_CheckedChanged);
            // 
            // cbVideo
            // 
            this.cbVideo.AutoSize = true;
            this.cbVideo.Location = new System.Drawing.Point(13, 21);
            this.cbVideo.Margin = new System.Windows.Forms.Padding(4);
            this.cbVideo.Name = "cbVideo";
            this.cbVideo.Size = new System.Drawing.Size(194, 21);
            this.cbVideo.TabIndex = 1039;
            this.cbVideo.Text = "Definir como tela de video";
            this.cbVideo.UseVisualStyleBackColor = true;
            this.cbVideo.CheckedChanged += new System.EventHandler(this.cbVideo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1036;
            this.label2.Text = "Timer (segundos)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 1035;
            this.label5.Text = "Cor da lista principal";
            // 
            // btnListColor
            // 
            this.btnListColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnListColor.Location = new System.Drawing.Point(536, 13);
            this.btnListColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnListColor.Name = "btnListColor";
            this.btnListColor.Size = new System.Drawing.Size(25, 22);
            this.btnListColor.TabIndex = 1034;
            this.toolTip.SetToolTip(this.btnListColor, "Click para mudar a cor");
            this.btnListColor.UseVisualStyleBackColor = true;
            this.btnListColor.Click += new System.EventHandler(this.btnListColor_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimer.Location = new System.Drawing.Point(529, 76);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(32, 25);
            this.btnTimer.TabIndex = 1038;
            this.btnTimer.Text = "+";
            this.toolTip.SetToolTip(this.btnTimer, "Gravar o valor do timer para a tela atual");
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 1033;
            this.label6.Text = "Cor da lista promocional";
            // 
            // mtbTimer
            // 
            this.mtbTimer.Location = new System.Drawing.Point(483, 76);
            this.mtbTimer.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTimer.Mask = "000";
            this.mtbTimer.Name = "mtbTimer";
            this.mtbTimer.Size = new System.Drawing.Size(37, 22);
            this.mtbTimer.TabIndex = 1037;
            // 
            // btnPromoListColor
            // 
            this.btnPromoListColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPromoListColor.Location = new System.Drawing.Point(536, 46);
            this.btnPromoListColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromoListColor.Name = "btnPromoListColor";
            this.btnPromoListColor.Size = new System.Drawing.Size(25, 22);
            this.btnPromoListColor.TabIndex = 1032;
            this.toolTip.SetToolTip(this.btnPromoListColor, "Click para mudar a cor");
            this.btnPromoListColor.UseVisualStyleBackColor = true;
            this.btnPromoListColor.Click += new System.EventHandler(this.btnPromoListColor_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnMinus.Image")));
            this.btnMinus.Location = new System.Drawing.Point(369, 18);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(53, 49);
            this.btnMinus.TabIndex = 1021;
            this.toolTip.SetToolTip(this.btnMinus, "Remover a ultima tela da Loja e Departamento selecionados");
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPlus.Image = ((System.Drawing.Image)(resources.GetObject("btnPlus.Image")));
            this.btnPlus.Location = new System.Drawing.Point(307, 18);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(53, 49);
            this.btnPlus.TabIndex = 1020;
            this.toolTip.SetToolTip(this.btnPlus, "Inserir uma nova tela na Loja e Departamento selecionados");
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnPhoto
            // 
            this.btnPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhoto.BackgroundImage")));
            this.btnPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPhoto.Location = new System.Drawing.Point(369, 71);
            this.btnPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhoto.Name = "btnPhoto";
            this.btnPhoto.Size = new System.Drawing.Size(53, 49);
            this.btnPhoto.TabIndex = 1019;
            this.toolTip.SetToolTip(this.btnPhoto, "Inserir a foto da grade atual");
            this.btnPhoto.UseVisualStyleBackColor = true;
            this.btnPhoto.Click += new System.EventHandler(this.btnPhoto_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.Location = new System.Drawing.Point(307, 71);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(53, 49);
            this.btnFind.TabIndex = 1000;
            this.toolTip.SetToolTip(this.btnFind, "Buscar a tela selecionada");
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvImage
            // 
            this.dgvImage.AllowUserToAddRows = false;
            this.dgvImage.AllowUserToDeleteRows = false;
            this.dgvImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImage.Location = new System.Drawing.Point(8, 18);
            this.dgvImage.Margin = new System.Windows.Forms.Padding(4);
            this.dgvImage.Name = "dgvImage";
            this.dgvImage.ReadOnly = true;
            this.dgvImage.Size = new System.Drawing.Size(587, 754);
            this.dgvImage.TabIndex = 1042;
            this.toolTip.SetToolTip(this.dgvImage, "Duplo click para gravar a foto da tela");
            this.dgvImage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImage_CellClick);
            this.dgvImage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImage_CellDoubleClick);
            // 
            // btnSeeBack
            // 
            this.btnSeeBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeeBack.BackgroundImage")));
            this.btnSeeBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSeeBack.Location = new System.Drawing.Point(1043, 528);
            this.btnSeeBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeeBack.Name = "btnSeeBack";
            this.btnSeeBack.Size = new System.Drawing.Size(53, 49);
            this.btnSeeBack.TabIndex = 1022;
            this.toolTip.SetToolTip(this.btnSeeBack, "Mostra ou oculta Foto e Grade para visualizar plano de fundo");
            this.btnSeeBack.UseVisualStyleBackColor = true;
            this.btnSeeBack.Click += new System.EventHandler(this.btnSeeBack_Click);
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteP.BackgroundImage")));
            this.btnDeleteP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteP.Location = new System.Drawing.Point(1043, 38);
            this.btnDeleteP.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(53, 49);
            this.btnDeleteP.TabIndex = 1016;
            this.btnDeleteP.Text = ">>";
            this.toolTip.SetToolTip(this.btnDeleteP, "Remover o produto selecionado da grade da esquerda");
            this.btnDeleteP.UseVisualStyleBackColor = true;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // btnInsertP
            // 
            this.btnInsertP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertP.BackgroundImage")));
            this.btnInsertP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsertP.Location = new System.Drawing.Point(1043, 95);
            this.btnInsertP.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertP.Name = "btnInsertP";
            this.btnInsertP.Size = new System.Drawing.Size(53, 49);
            this.btnInsertP.TabIndex = 1015;
            this.btnInsertP.Text = "<<";
            this.toolTip.SetToolTip(this.btnInsertP, "Adicionar o produto selecionado da grade da direita para a esquerda");
            this.btnInsertP.UseVisualStyleBackColor = true;
            this.btnInsertP.Click += new System.EventHandler(this.btnInsertP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvImage);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.dgvProd);
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Location = new System.Drawing.Point(1104, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(608, 634);
            this.groupBox2.TabIndex = 1020;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos do departamento";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(27, 46);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 22);
            this.txtSearch.TabIndex = 1044;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.Location = new System.Drawing.Point(276, 43);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 28);
            this.btnSearch.TabIndex = 1043;
            this.btnSearch.Text = "Buscar";
            this.toolTip.SetToolTip(this.btnSearch, "Click para mudar a cor");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReload.Location = new System.Drawing.Point(376, 43);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(92, 28);
            this.btnReload.TabIndex = 1045;
            this.btnReload.Text = "Atualizar";
            this.toolTip.SetToolTip(this.btnReload, "Click para mudar a cor");
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnUpProd
            // 
            this.btnUpProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpProd.Image = ((System.Drawing.Image)(resources.GetObject("btnUpProd.Image")));
            this.btnUpProd.Location = new System.Drawing.Point(1043, 151);
            this.btnUpProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpProd.Name = "btnUpProd";
            this.btnUpProd.Size = new System.Drawing.Size(53, 49);
            this.btnUpProd.TabIndex = 1022;
            this.toolTip.SetToolTip(this.btnUpProd, "Mudar posição do produto selecionado na tela");
            this.btnUpProd.UseVisualStyleBackColor = true;
            this.btnUpProd.Click += new System.EventHandler(this.btnUpProd_Click);
            // 
            // btnDownProd
            // 
            this.btnDownProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDownProd.Image = ((System.Drawing.Image)(resources.GetObject("btnDownProd.Image")));
            this.btnDownProd.Location = new System.Drawing.Point(1043, 208);
            this.btnDownProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownProd.Name = "btnDownProd";
            this.btnDownProd.Size = new System.Drawing.Size(53, 49);
            this.btnDownProd.TabIndex = 1021;
            this.toolTip.SetToolTip(this.btnDownProd, "Mudar posição do produto selecionado na tela");
            this.btnDownProd.UseVisualStyleBackColor = true;
            this.btnDownProd.Click += new System.EventHandler(this.btnDownProd_Click);
            // 
            // btnPriceUpdate
            // 
            this.btnPriceUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPriceUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnPriceUpdate.Image")));
            this.btnPriceUpdate.Location = new System.Drawing.Point(1043, 585);
            this.btnPriceUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPriceUpdate.Name = "btnPriceUpdate";
            this.btnPriceUpdate.Size = new System.Drawing.Size(53, 49);
            this.btnPriceUpdate.TabIndex = 1023;
            this.toolTip.SetToolTip(this.btnPriceUpdate, "Atualiza os preços da loja atual");
            this.btnPriceUpdate.UseVisualStyleBackColor = true;
            this.btnPriceUpdate.Click += new System.EventHandler(this.btnPriceUpdate_Click);
            // 
            // FormMIPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 663);
            this.Controls.Add(this.btnPriceUpdate);
            this.Controls.Add(this.btnUpProd);
            this.Controls.Add(this.btnDownProd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteP);
            this.Controls.Add(this.btnInsertP);
            this.Controls.Add(this.btnSeeBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMIPP";
            this.Text = "MIPP";
            this.Load += new System.EventHandler(this.FormScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbScreen;
        private System.Windows.Forms.ComboBox cmbLoja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.Button btnDeleteP;
        internal System.Windows.Forms.Button btnInsertP;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button btnPhoto;
        internal System.Windows.Forms.Button btnMinus;
        internal System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        internal System.Windows.Forms.Button btnSeeBack;
        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.Button btnUpProd;
        internal System.Windows.Forms.Button btnDownProd;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Button btnPromoListColor;
        internal System.Windows.Forms.Button btnPriceUpdate;
        internal System.Windows.Forms.Button btnListColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbTimer;
        internal System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbVideo;
        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.PictureBox pbScreen;
        private System.Windows.Forms.DataGridView dgvImage;
        private System.Windows.Forms.DataGridView dgvProdScreen;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.CheckBox cbPhoto;
    }
}