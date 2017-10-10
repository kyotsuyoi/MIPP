using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MIPP.Forms
{
    public partial class FormBIPP : Form
    {
        DataSet DS = new DataSet();
        BIPP BIPP = new BIPP();
        Department De = new Department();
        Product Pr = new Product();
        Shop Sh = new Shop();
        int prod;

        public FormBIPP()
        {
            InitializeComponent();
        }
        private void FormBIPP_Load(object sender, EventArgs e)
        {
            var DT = De.LoadCombo_Department();

            while (DT.Read())
            {
                cmbDepart.Items.Add(String.Format("{0}", DT[0]));
            }

            DT = Sh.LoadCombo_Shop();

            while (DT.Read())
            {
                cmbShop.Items.Add(String.Format("{0}", DT[0]));
            }
            dgvProduct.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(mtbID.Text == "" || (mtbID1.Text == "" || mtbID2.Text == "" || mtbID3.Text == ""))
            {
                MessageBox.Show("Vincule um produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int N = 0;
            if (BIPP.Insert(int.Parse(mtbID.Text), int.Parse(mtbID1.Text), int.Parse(mtbID2.Text), int.Parse(mtbID3.Text), int.Parse(cmbShop.Text)) == false) { return; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void LoadGrid()
        {
            DS = BIPP.LoadGrid(int.Parse(cmbShop.Text));
            dgvBIPP.DataSource = DS.Tables[0];
        }

        private void LoadGridProd()
        {
            DS = Pr.LoadGrid(int.Parse(cmbShop.Text));
            dgvProduct.DataSource = DS.Tables[0];
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "")
            {
                MessageBox.Show("Insira o ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchID(int.Parse(mtbID.Text));
            dgvBIPP.DataSource = DS.Tables[0];
        }

        private void btnSearchDepart_Click(object sender, EventArgs e)
        {
            if (cmbDepart.Text == "")
            {
                MessageBox.Show("Selecione o Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchDepart(int.Parse(cmbDepart.Text));
            dgvBIPP.DataSource = DS.Tables[0];
        }

        private void btnSearchDescription_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Insira a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchDesciption(txtDescription.Text);
            dgvBIPP.DataSource = DS.Tables[0];
        }
        private void ClearAll()
        {
            mtbID.Text = "";
            txtDescription.Clear();
            cmbDepart.Text = "";
            lblDepart.Text = "";
            pbPhoto.Image = null;
            LoadGrid();
        }

        private void cmbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepart.Text == "")
            {
                lblDepart.Text = "";
                return;
            }
            lblDepart.Text = De.LoadDepart(int.Parse(cmbDepart.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDepart.Text = "";

            int y;

            try
            {
                y = dgvProduct.CurrentRow.Index;

                if ((string)dgvProduct[1, y].Value == "" || ((double)dgvProduct[3, y].Value) == 0)
                {
                    MessageBox.Show("Produto sem descrição ou preço", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (prod == 0)
                {
                    mtbID.Text = (dgvProduct[0, y].Value).ToString();
                    txtDescription.Text = (string)dgvProduct[1, y].Value;
                    txtPrice.Text = (dgvProduct[3, y].Value).ToString();
                    pbPhoto.Image = Pr.LoadImage(int.Parse(mtbID.Text));
                    dgvProduct.Visible = false;
                }

                if (prod == 1)
                {

                    mtbID1.Text = (dgvProduct[0, y].Value).ToString();
                    txtDescription1.Text = (string)dgvProduct[1, y].Value;
                    txtPrice1.Text = (dgvProduct[3, y].Value).ToString();
                    pbPhoto1.Image = Pr.LoadImage(int.Parse(mtbID1.Text));
                    dgvProduct.Visible = false;
                }
                if (prod == 2)
                {

                    mtbID2.Text = (dgvProduct[0, y].Value).ToString();
                    txtDescription2.Text = (string)dgvProduct[1, y].Value;
                    txtPrice2.Text = (dgvProduct[3, y].Value).ToString();
                    pbPhoto2.Image = Pr.LoadImage(int.Parse(mtbID2.Text));
                    dgvProduct.Visible = false;
                }
                if (prod == 3)
                {

                    mtbID3.Text = (dgvProduct[0, y].Value).ToString();
                    txtDescription3.Text = (string)dgvProduct[1, y].Value;
                    txtPrice3.Text = (dgvProduct[3, y].Value).ToString();
                    pbPhoto3.Image = Pr.LoadImage(int.Parse(mtbID3.Text));
                    dgvProduct.Visible = false;
                }
                prod = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnLoadGrid_Click(object sender, EventArgs e)
        {
            dgvProduct.Visible = true;
            prod = 0;
        }

        private void btnLoadGrid1_Click(object sender, EventArgs e)
        {
            dgvProduct.Visible = true;
            prod = 1;
        }

        private void btnLoadGrid2_Click(object sender, EventArgs e)
        {
            dgvProduct.Visible = true;
            prod = 2;
        }

        private void btnLoadGrid3_Click(object sender, EventArgs e)
        {
            dgvProduct.Visible = true;
            prod = 3;
        }

        private void cmbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbShop.Text == "") { return; }
            lblShop.Text = Sh.LoadShop(int.Parse(cmbShop.Text));
            LoadGrid();
            LoadGridProd();
        }

        private void dgvBIPP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDepart.Text = "";

            int y;

            try
            {
                y = dgvBIPP.CurrentRow.Index;
                
                int ID = ((int)dgvBIPP[0, y].Value);
                int ShopID = int.Parse(cmbShop.Text);

                mtbID.Text = ID.ToString();
                txtDescription.Text = BIPP.LoadDescription(ID);
                cmbDepart.Text = BIPP.LoadDepartament(ID).ToString();
                txtPrice.Text = BIPP.LoadPrice(ID, ShopID).ToString();
                pbPhoto.Image = Pr.LoadImage(ID);

                ID = ((int)dgvBIPP[1, y].Value);

                if (ID != 0)
                {
                    mtbID1.Text = ID.ToString();
                    txtDescription1.Text = BIPP.LoadDescription(ID);
                    txtPrice1.Text = BIPP.LoadPrice(ID, ShopID).ToString();
                    pbPhoto1.Image = Pr.LoadImage(ID);
                }


                ID = ((int)dgvBIPP[2, y].Value);

                if (ID != 0)
                {
                    mtbID2.Text = ID.ToString();
                    txtDescription2.Text = BIPP.LoadDescription(ID);
                    txtPrice2.Text = BIPP.LoadPrice(ID, ShopID).ToString();
                    pbPhoto2.Image = Pr.LoadImage(ID);
                }


                ID = ((int)dgvBIPP[3, y].Value);

                if (ID != 0)
                {
                    mtbID3.Text = ID.ToString();
                    txtDescription3.Text = BIPP.LoadDescription(ID);
                    txtPrice3.Text = BIPP.LoadPrice(ID, ShopID).ToString();
                    pbPhoto3.Image = Pr.LoadImage(ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    } 

}
