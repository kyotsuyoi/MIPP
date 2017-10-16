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
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Equivalente";
            checkColumn.HeaderText = "Equivalente";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            dgvBIPPEquival.Columns.Add(checkColumn);
        }

        private void LoadGridProd()
        {
            DS = BIPP.LoadGrid1(int.Parse(cmbShop.Text));
            dgvProduct.DataSource = DS.Tables[0];
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Equivalente";
            checkColumn.HeaderText = "Equivalente";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            dgvProduct.Columns.Add(checkColumn);
        }

        private void LoadGridInsertEquival()
        {
            DS = BIPP.LoadGrid1(int.Parse(cmbShop.Text));
            dgvInsertEquival.DataSource = DS.Tables[0];
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "")
            {
                MessageBox.Show("Insira o ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = BIPP.LoadGrid_SearchID1(int.Parse(mtbID.Text));
            dgvProduct.DataSource = DS.Tables[0];
        }
        
        private void btnSearchDepart_Click(object sender, EventArgs e)
        {
            if (cmbDepart.Text == "")
            {
                MessageBox.Show("Selecione o Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = BIPP.LoadGrid_SearchDepart1(int.Parse(cmbDepart.Text));
            dgvProduct.DataSource = DS.Tables[0];
        }

        private void btnSearchDescription_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Insira a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = BIPP.LoadGrid_SearchDesciption1(txtDescription.Text);
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

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            cmbDepart.Text = "";

            int y;
            string x;

            try
            {
                y = dgvProduct.CurrentRow.Index;
                x = (dgvProduct[0, y].Value).ToString();

                mtbID.Text = x;
                txtDescription.Text = (BIPP.LoadDescription(x)).ToString();
                txtPrice.Text = (BIPP.LoadPrice(x,int.Parse(cmbShop.Text))).ToString();
                cmbDepart.Text = (BIPP.LoadDepartament(x)).ToString();
                pbPhoto.Image = BIPP.LoadImage1(x);
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

        private void dgvBIPPEquival_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvInsertEquival_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDesEquival_Click(object sender, EventArgs e)
        {
            if (txtDesEquival.Text == "")
            {
                MessageBox.Show("Insira a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = BIPP.LoadGrid_SearchDesciption1(txtDesEquival.Text);
            dgvInsertEquival.DataSource = DS.Tables[0];
        }
    } 

}
