using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIPP.Forms;
using MySql.Data.MySqlClient;

namespace MIPP
{
    public partial class FormMIPP : Form
    {

        DataSet DS = new DataSet();
        Forms.MIPP SC = new Forms.MIPP();
        Midia MD = new Midia();
        Shop Sh = new Shop();
        Department De = new Department();

        int vDepart = 0;
        int ImageID = 0;

        public FormMIPP()
        {
            InitializeComponent();
        }

        private void FormScreen_Load(object sender, EventArgs e)
        {
            var DT = Sh.LoadCombo_Shop();

            while (DT.Read())
            {
                cmbLoja.Items.Add(String.Format("{0}", DT[0]));
            }

            DT = SC.LoadCombo_Departamento();

            while (DT.Read())
            {
                cmbDepart.Items.Add(String.Format("{0}", DT[0]));
            }
            dgvImage.Visible = false;
            axWMP.Visible = false;
            this.Width = 1320;

        }
        
        private void btnFind_Click(object sender, EventArgs e) {
            if (cmbLoja.Text == "")
            {
                MessageBox.Show("Selecione a Loja!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbDepart.Text == "")
            {
                MessageBox.Show("Selecione o Departamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmbScreen.Text == "")
            {
                MessageBox.Show("Selecione a Tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            LoadDGV_Prod();

            vDepart = int.Parse(cmbDepart.Text);
            int vShop = int.Parse(cmbLoja.Text);

            if(SC.LoadType_Screen(cmbScreen.SelectedIndex, vShop, vDepart) == 2)
            {
                cbVideo.Checked = true;
                var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vid.mp4");

                try
                {
                    byte[] video = SC.LoadVIdeo_Screen(cmbScreen.SelectedIndex, vShop, vDepart);
                    File.WriteAllBytes(strTempFile, video);
                    axWMP.URL = strTempFile;
                    axWMP.Ctlcontrols.play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (SC.LoadType_Screen(cmbScreen.SelectedIndex, vShop, vDepart) == 3)
            {
                cbPhoto.Checked = true;
                pbBackground.Image = SC.LoadImage_Screen(cmbScreen.SelectedIndex, vShop, vDepart);
                return;
            }
            else
            {
                cbVideo.Checked = false;
                cbPhoto.Checked = false;
                pbScreen.Image = SC.LoadImage_Screen(cmbScreen.SelectedIndex, vShop, vDepart);
                pbBackground.Image = SC.LoadImage_BackgroundScreen(int.Parse(cmbDepart.Text));
            }

            DS = SC.LoadGrid_ProdScreen(vShop, vDepart, cmbScreen.SelectedIndex);
            dgvProdScreen.DataSource = DS.Tables[0];

            dgvProdScreen.Columns[0].Width = 50;
            dgvProdScreen.Columns[1].Width = 100;
            dgvProdScreen.Columns[2].Width = 200;
            dgvProdScreen.Columns[3].Width = 70;

            mtbTimer.Text = SC.LoadTimer(cmbScreen.SelectedIndex, vShop, vDepart).ToString();

            string ListColor = SC.LoadListColor(cmbScreen.SelectedIndex, vShop, vDepart);
            Color color = System.Drawing.ColorTranslator.FromHtml("#" + ListColor);
            btnListColor.BackColor = color;
            ListColor = SC.LoadPromoListColor(cmbScreen.SelectedIndex, vShop, vDepart);
            color = System.Drawing.ColorTranslator.FromHtml("#" + ListColor);
            btnPromoListColor.BackColor = color;

            if (pbScreen.Visible == false)
            {
                pbScreen.Visible = true;
                dgvProdScreen.Visible = true;
            }
        }

        private void btnInsertP_Click(object sender, EventArgs e)
        {
            InsertP();
        }

        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            DeleteP();
        }

        private void cmbLoja_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCombo_Screen();
            LoadDGV_Prod();
        }

        private void cmbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbDepart.Text == "")
            {
                dgvImage.DataSource = null;
                dgvProd.DataSource = null;
                pbBackground.Image = null;
                pbScreen.Image = null;
                lblDepart.Text = "";
                return;
            }
            lblDepart.Text = De.LoadDepart(int.Parse(cmbDepart.Text));

            LoadCombo_Screen();
            LoadDGV_Prod();
            pbBackground.Image = SC.LoadImage_BackgroundScreen(int.Parse(cmbDepart.Text));

        }

        private Boolean ComboTest()
        {
            if (cmbLoja.Text == "" || cmbDepart.Text == "" || cmbScreen.Text == "")
            {
                MessageBox.Show("Verifique se os campos Loja, Departamento e Tela estão selecionados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if ((cmbLoja.Text == "") || (cmbDepart.Text == ""))
            {
                MessageBox.Show("Selecione Loja e Departamento para inserir a nova tela!","Atenção",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Deseja criar uma nova tela?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                axWMP.close();
                cbVideo.Checked = false;
                int vTimer = 0;
                if (mtbTimer.Text != "")
                {
                    vTimer = int.Parse(mtbTimer.Text);
                }

                if (SC.InsertScreen(cmbScreen.Items.Count, int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), ImageID, vTimer) == false)
                {
                    return;
                }
                
                cmbScreen.Items.Add(cmbScreen.Items.Count);
                cmbScreen.SelectedIndex = cmbScreen.Items.Count - 1;

                if (int.Parse(cmbDepart.Text) != vDepart)
                {
                    vDepart = int.Parse(cmbDepart.Text);
                    //pbBackground.Image = SC.LoadImage_BackgroundScreen(vDepart);
                }

                pbScreen.Image = null;

                DS = SC.LoadGrid_ProdScreen(int.Parse(cmbLoja.Text), vDepart, cmbScreen.SelectedIndex);
                dgvProdScreen.DataSource = DS.Tables[0];

                if (pbScreen.Visible == false)
                {
                    pbScreen.Visible = true;
                    dgvProdScreen.Visible = true;
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            
            if (int.Parse(cmbLoja.Text) <= 0 || int.Parse(cmbDepart.Text) <= 0)
            {
                MessageBox.Show("Selecione Loja e Departamento para apagar a ultima tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Deseja apagar a ultima tela?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                axWMP.close();
                cbVideo.Checked = false;
                cbPhoto.Checked = false;
                if (SC.DeleteScreen(cmbScreen.Items.Count - 1, int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text)) == false) { return; }
                LoadCombo_Screen();
                cmbScreen.SelectedItem = 0;
                dgvProdScreen.DataSource = null;
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            
            if (dgvImage.Visible == false)
            {
                dgvImage.Visible = true;
            }
            else {
                dgvImage.Visible = false;
                return;
            }

            if (dgvImage.RowCount == 0)
            {
                MessageBox.Show("Não foram encontradas imagens para este departamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cmbDepart.Text != "")
            {
                LoadImageOrVideoScreenGridByDepart(cbVideo.Checked);
            }
            dgvImage.Visible = true;
        }

        private void btnSeeBack_Click(object sender, EventArgs e)
        {
            if (pbScreen.Visible == true)
            {
                pbScreen.Visible = false;
                dgvProdScreen.Visible = false;
            }
            else
            {
                pbScreen.Visible = true;
                dgvProdScreen.Visible = true;
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if (cmbLoja.Text == "" || cmbDepart.Text == "")
            {
                MessageBox.Show("Selecione Loja e Departamento e tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (mtbTimer.Text == "" || mtbTimer.Text == "0")
            {
                MessageBox.Show("Verifique o valor do timer (precisa ser maior que 0)!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (SC.UpdateTimer(cmbScreen.SelectedIndex, int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), int.Parse(mtbTimer.Text)) == true)
            {
                MessageBox.Show("Timer foi inserido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvImage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y;
            axWMP.close();
            try
            {
                y = dgvImage.CurrentRow.Index;

                ImageID = (int)dgvImage[0, y].Value;

                if (cbVideo.Checked == true)
                {
                    var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vid.mp4");

                    try
                    {
                        byte[] video = MD.LoadSpecificVideo(ImageID);
                        File.WriteAllBytes(strTempFile, video);
                        axWMP.URL = strTempFile;
                        axWMP.Ctlcontrols.play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (cbPhoto.Checked==true)
                {
                    pbBackground.Image = MD.LoadSpecificImage(ImageID);
                }
                else
                {
                    pbScreen.Image = MD.LoadSpecificImage(ImageID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvImage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbScreen.Text == "" || cmbLoja.Text == "" || cmbDepart.Text == "" || ImageID == 0)
            {
                MessageBox.Show("Selecione Loja, Departamento, Tela e a imagem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dgvImage.Visible = false;
            SC.UpdateImage_Screen(int.Parse(cmbScreen.Text), int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), ImageID);
        }

        private void dgvProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InsertP();
        }

        private void dgvProdScreen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteP();
        }

        private void btnUpProd_Click(object sender, EventArgs e)
        {
            int y;
            try
            {
                y = dgvProdScreen.CurrentRow.Index;

                if (y == 0) { return; }

                int ShopID = int.Parse(cmbLoja.Text);
                int DepartID = int.Parse(cmbDepart.Text);
                int ScreenID = int.Parse(cmbScreen.Text);

                int ProdID = (int)dgvProdScreen[1, y].Value;
                int Pos = (int)dgvProdScreen[0, y].Value;

                y--;
                
                int ProdID1 = (int)dgvProdScreen[1, y].Value;
                int Pos1 = (int)dgvProdScreen[0, y].Value;

                SC.UpdateP(ShopID,DepartID,ScreenID,ProdID,0);
                SC.UpdateP(ShopID, DepartID, ScreenID, ProdID1, Pos);
                SC.UpdateP(ShopID, DepartID, ScreenID, ProdID, Pos1);
                
                DS = SC.LoadGrid_ProdScreen(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), cmbScreen.SelectedIndex);
                dgvProdScreen.DataSource = DS.Tables[0];

                dgvProdScreen.Rows[y].Selected = true;
                dgvProdScreen.CurrentCell = dgvProdScreen.Rows[y].Cells[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 
        }

        private void btnDownProd_Click(object sender, EventArgs e)
        {
            int y;
            try
            {
                y = dgvProdScreen.CurrentRow.Index;

                if (y == dgvProdScreen.RowCount - 1) { return;  }
                
                int ShopID = int.Parse(cmbLoja.Text);
                int DepartID = int.Parse(cmbDepart.Text);
                int ScreenID = int.Parse(cmbScreen.Text);

                int ProdID = (int)dgvProdScreen[1, y].Value;
                int Pos = (int)dgvProdScreen[0, y].Value;

                y++;

                int ProdID1 = (int)dgvProdScreen[1, y].Value;
                int Pos1 = (int)dgvProdScreen[0, y].Value;

                SC.UpdateP(ShopID, DepartID, ScreenID, ProdID, 0);
                SC.UpdateP(ShopID, DepartID, ScreenID, ProdID1, Pos);
                SC.UpdateP(ShopID, DepartID, ScreenID, ProdID, Pos1);

                DS = SC.LoadGrid_ProdScreen(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), cmbScreen.SelectedIndex);
                dgvProdScreen.DataSource = DS.Tables[0];

                dgvProdScreen.Rows[y].Selected = true;
                dgvProdScreen.CurrentCell = dgvProdScreen.Rows[y].Cells[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnListColor_Click(object sender, EventArgs e)
        {
            if (cmbLoja.Text == "" || cmbDepart.Text == "" || cmbScreen.Text == "")
            {
                MessageBox.Show("Selecione a tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string ListColor = (colorDialog1.Color.ToArgb() & 0xFFFFFF).ToString("X6");
                btnListColor.BackColor = colorDialog1.Color;
                SC.UpdateListColor(int.Parse(cmbScreen.Text), int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), ListColor);
            }
        }

        private void btnPromoListColor_Click(object sender, EventArgs e)
        {
            if (cmbLoja.Text == "" || cmbDepart.Text == "" || cmbScreen.Text == "")
            {
                MessageBox.Show("Selecione a tela!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string ListColor = (colorDialog1.Color.ToArgb() & 0xFFFFFF).ToString("X6");
                btnPromoListColor.BackColor = colorDialog1.Color;
                SC.UpdatePromoListColor(int.Parse(cmbScreen.Text), int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), ListColor);
            }
        }

        //
        //>>>>FUNCTIONS<<<<
        //

        private void LoadCombo_Screen()
        {

            pbScreen.Image = null;
            cmbScreen.Items.Clear();

            if (cmbLoja.Text == "" || cmbDepart.Text == "") { return; }

            MySqlDataReader reader = SC.LoadCombo_Screen(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text));

            if (reader == null) { return; }

            cmbScreen.Items.Add("");
            while (reader.Read())
            {
                cmbScreen.Items.Add(String.Format("{0}", reader[0]));
            }
        }

        private void LoadDGV_Prod()
        {

            if (cmbLoja.Text == "" || cmbDepart.Text == "") { return; }

            dgvProdScreen.DataSource = null;

            DS = SC.LoadGrid_Prod(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), cmbScreen.SelectedIndex);
            if (DS == null) { return; }

            dgvProd.DataSource = DS.Tables[0];

            dgvProd.Columns[0].Width = 100;
            dgvProd.Columns[1].Width = 200;
            dgvProd.Columns[2].Width = 70;

        }

        private void InsertP()
        {
            if (ComboTest() == false) { return; }

            if (dgvProdScreen.RowCount > 16)
            {
                MessageBox.Show("Limite por tela atingido. Numero máximo de 17 produtos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int y = dgvProd.CurrentRow.Index;
            double val = (double)dgvProd[2, y].Value;
            string desc = (string)dgvProd[1, y].Value;

            if (val == 0)
            {
                MessageBox.Show("O valor deste produto está em zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (desc == "")
            {
                MessageBox.Show("O produto está sem descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int vPos;
            if (dgvProdScreen.RowCount == 0)
            {
                vPos = 1;
            }
            else
            {
                vPos = (int)dgvProdScreen[0, dgvProdScreen.RowCount - 1].Value + 1;
            }
            if ((SC.InsertP(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), cmbScreen.SelectedIndex, (int)dgvProd[0, y].Value, vPos)) == false)
            {
                return;
            }

            dgvProd.Rows.RemoveAt(y);

            DS = SC.LoadGrid_ProdScreen(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), cmbScreen.SelectedIndex);
            dgvProdScreen.DataSource = DS.Tables[0];
        }

        private void DeleteP()
        {
            if (ComboTest() == false) { return; }

            if (dgvProdScreen.RowCount < 1)
            {
                MessageBox.Show("Não há mais produtos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int y = dgvProdScreen.CurrentRow.Index;
            if (SC.DeleteP(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), cmbScreen.SelectedIndex, (int)dgvProdScreen[1, y].Value, (int)dgvProdScreen[0, y].Value) == false)
            {
                return;
            }

            DS = SC.LoadGrid_ProdScreen(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), cmbScreen.SelectedIndex);
            dgvProdScreen.DataSource = DS.Tables[0];


            DS = SC.LoadGrid_Prod(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), cmbScreen.SelectedIndex);
            dgvProd.DataSource = DS.Tables[0];
        }

        private void btnPriceUpdate_Click(object sender, EventArgs e)
        {
            if (cmbLoja.Text == "")
            {
                MessageBox.Show("Selecione a loja!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var php = new System.Net.WebClient();
            try
            {
                php.DownloadString("http://192.168.0.221:70/MIPP/insereProdutos.php?Unidade=" + cmbLoja.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("Preços atualizados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void cbVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVideo.Checked == true)
            {
                cbPhoto.Checked = false;
                gbScreen.Visible = false;
                axWMP.Visible = true;
            }
            else if (cbPhoto.Checked == false)
            {
                gbScreen.Visible = true;
                pbScreen.Visible = true;
                pbBackground.Visible = true;
                dgvProdScreen.Visible = true;
                axWMP.Visible = !true;
            }

            LoadImageOrVideoScreenGridByDepart(cbVideo.Checked);
        }

        private void cbPhoto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPhoto.Checked == true)
            {
                cbVideo.Checked = false;
                gbScreen.Visible = true;
                pbBackground.Visible = true;
                pbScreen.Visible = false;
                dgvProdScreen.Visible = false;
                axWMP.Visible = false;
            }
            else if (cbVideo.Checked == false)
            {
                gbScreen.Visible = true;
                pbScreen.Visible = true;
                pbBackground.Visible = true;
                dgvProdScreen.Visible = true;
            }
        }

        private void LoadImageOrVideoScreenGridByDepart(Boolean vid)
        {
            axWMP.close();
            if (cmbLoja.Text == "" || cmbDepart.Text == "") { return; }

            if (cbVideo.Checked == true)
            {
                DS = MD.LoadVideoScreenGridByDepart(int.Parse(cmbDepart.Text));
            }
            else if (cbPhoto.Checked==true){
                DS = MD.LoadPhotoGridByDepart(int.Parse(cmbDepart.Text));
            }
            else
            {
                DS = MD.LoadImageScreenGridByDepart(int.Parse(cmbDepart.Text));
            }

            dgvImage.DataSource = DS.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbLoja.Text == "" || cmbDepart.Text == "" || cmbScreen.Text == "" || txtSearch.Text == "")
            {
                MessageBox.Show("Selecione a loja, Departamento, Tela e preencha o campo de pesquisa!", "Atenção"
                ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = SC.LoadGrid_Search(int.Parse(cmbLoja.Text),int.Parse(cmbDepart.Text),int.Parse(cmbScreen.Text),txtSearch.Text);
            dgvProd.DataSource = DS.Tables[0];
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (cmbLoja.Text == "" || cmbDepart.Text == "" || cmbScreen.Text == "")
            {
                MessageBox.Show("Selecione a loja, Departamento, Tela!", "Atenção"
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = SC.LoadGrid_Prod(int.Parse(cmbLoja.Text), int.Parse(cmbDepart.Text), int.Parse(cmbScreen.Text));
            dgvProd.DataSource = DS.Tables[0];
        }

    }
}
