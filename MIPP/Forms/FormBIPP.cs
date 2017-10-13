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
            dgvBIPPEquival.DataSource = DS.Tables[0];
        }

        private void LoadGridProd()
        {
            DS = Pr.LoadGrid(int.Parse(cmbShop.Text));
            dgvProduct.DataSource = DS.Tables[0];
        }

        private void LoadGridInsertEquival()
        {
            DS = Pr.LoadGrid(int.Parse(cmbShop.Text));
            dgvInsertEquival.DataSource = DS.Tables[0];
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "")
            {
                MessageBox.Show("Insira o ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchID(int.Parse(mtbID.Text));
            dgvProduct.DataSource = DS.Tables[0];
        }
        
        private void btnSearchDepart_Click(object sender, EventArgs e)
        {
            if (cmbDepart.Text == "")
            {
                MessageBox.Show("Seleyurw1cione o Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchDepart(int.Parse(cmbDepart.Text));
            dgvProduct.DataSource = DS.Tables[0];
        }

        private void btnSearchDescription_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Insira a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchDesciption(txtDescription.Text);
            dgvProduct.DataSource = DS.Tables[0];
        }
        private void ClearAll()
        {
            mtbID.Text = "";
            txtDescription.Clear();
            cmbDepart.Text = "";
            lblDepart.Text = "";
            pbPhoto.Image = null;
            txtPrice.Clear();
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
                
                    mtbID.Text = (dgvProduct[0, y].Value).ToString();
                    txtDescription.Text = (string)dgvProduct[1, y].Value;
                    txtPrice.Text = (dgvProduct[3, y].Value).ToString();
                    cmbDepart.Text = (dgvProduct[2, y].Value).ToString();
                    pbPhoto.Image = Pr.LoadImage(int.Parse(mtbID.Text));
                    dgvProduct.Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnLoadGrid_Click(object sender, EventArgs e)
        {
            if(dgvProduct.Visible == true)
            {
                dgvProduct.Visible = false;
            } else
            {
                dgvProduct.Visible = true;
            }
        }
        

        private void cmbShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbShop.Text == "") { return; }
            lblShop.Text = Sh.LoadShop(int.Parse(cmbShop.Text));
            LoadGrid();
            LoadGridProd();
            LoadGridInsertEquival();
        }

        private void dgvBIPPEquival_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDepart.Text = "";

            int y;

            try
            {
                y = dgvBIPPEquival.CurrentRow.Index;
                
                int ID = ((int)dgvBIPPEquival[0, y].Value);
                int ShopID = int.Parse(cmbShop.Text);

                mtbID.Text = ID.ToString();
                txtDescription.Text = BIPP.LoadDescription(ID);
                cmbDepart.Text = BIPP.LoadDepartament(ID).ToString();
                txtPrice.Text = BIPP.LoadPrice(ID, ShopID).ToString();
                pbPhoto.Image = Pr.LoadImage(ID);

                ID = ((int)dgvBIPPEquival[1, y].Value);
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvInsertEquival_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbDepart.Text = "";

            int y;

            try
            {
                y = dgvInsertEquival.CurrentRow.Index;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDesEquival_Click(object sender, EventArgs e)
        {
            if (txtDesEquival.Text == "")
            {
                MessageBox.Show("Insira a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = BIPP.LoadGrid_SearchDesciption(txtDesEquival.Text);
            dgvInsertEquival.DataSource = DS.Tables[0];
        }
    } 

}
