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
        int id_prod;

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
        
        private void LoadGrid()
        {
            DS = BIPP.LoadGrid(int.Parse(cmbShop.Text), id_prod);
            dgvBIPPEquival.DataSource = DS.Tables[0];
            dgvBIPPEquival.Columns[0].Visible = false;
            dgvBIPPEquival.Columns[1].Visible = false;
            dgvBIPPEquival.Columns[2].Visible = false;
            dgvBIPPEquival.Columns[3].Width = 177;
            dgvBIPPEquival.Columns[4].Width = 50;   

        }

        private void LoadGridProd()
        {
            DS = BIPP.LoadGrid1(int.Parse(cmbShop.Text));
            dgvProduct.DataSource = DS.Tables[0];
            dgvProduct.Columns[0].Width = 68;
            dgvProduct.Columns[1].Width = 155;
            dgvProduct.Columns[2].Width = 34;
            dgvProduct.Columns[3].Width = 50;
        }

        private void LoadGridInsertEquival()
        {
            DS = BIPP.LoadGrid1(int.Parse(cmbShop.Text));
            dgvInsertEquival.DataSource = DS.Tables[0];
            dgvInsertEquival.Columns[0].Width = 68;
            dgvInsertEquival.Columns[1].Width = 161;
            dgvInsertEquival.Columns[2].Width = 34;
            dgvInsertEquival.Columns[3].Width = 50;
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
            id_prod = 0;
            mtbID.Text = "";
            txtDescription.Clear();
            cmbDepart.Text = "";
            lblDepart.Text = "";
            pbPhoto.Image = null;
            txtPrice.Clear();
            txtDesEquival.Clear();
            dgvBIPPEquival.DataSource = null;
            dgvInsertEquival.DataSource = null;
            dgvProduct.DataSource = null;
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
            cmbShop.Text = "";
            lblShop.Text = "";
            ClearAll();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            cmbDepart.Text = "";

            int y;

            try
            {
                y = dgvProduct.CurrentRow.Index;

                id_prod = (int)dgvProduct[0, y].Value;
                mtbID.Text = id_prod.ToString();
                txtDescription.Text = (string)dgvProduct[1, y].Value;
                txtPrice.Text = (dgvProduct[3, y].Value).ToString();
                cmbDepart.Text = (dgvProduct[2, y].Value).ToString();
                pbPhoto.Image = BIPP.LoadImage(id_prod);
                dgvProduct.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadGrid();
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
            ClearAll();
            LoadGrid();
            LoadGridProd();
            LoadGridInsertEquival();
        }

        private void dgvBIPPEquival_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInsertEquival_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int y;
            y = dgvInsertEquival.CurrentRow.Index;
            int id_equival = (int)dgvInsertEquival[0, y].Value;
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int y;
            y = dgvInsertEquival.CurrentRow.Index;
            int id_equival = (int)dgvInsertEquival[0, y].Value;

            if (BIPP.Insert(id_prod, id_equival, int.Parse(cmbShop.Text))==false) { return; }

            MessageBox.Show("Salvo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            if (id_prod == 0)
            {
                MessageBox.Show("Verifique o ID do produto!","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            LoadGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y;
            y = dgvBIPPEquival.RowCount-1;
            while (y > -1)
            {
                int id_prod = (int)dgvBIPPEquival[0, y].Value;
                int id_equival = (int)dgvBIPPEquival[1, y].Value;
                int id_loja = (int)dgvBIPPEquival[2, y].Value;
                bool equiv = (bool)dgvBIPPEquival[3, y].Value;
                BIPP.Update(id_prod,id_equival, id_loja, equiv);
                y-=1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int y;
            y = dgvBIPPEquival.CurrentRow.Index;
            int id_equival = (int)dgvInsertEquival[0, y].Value;

            if (BIPP.Delete(id_prod, id_equival, int.Parse(cmbShop.Text)) == false) { return; }

            MessageBox.Show("Removido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (id_prod == 0)
            {
                MessageBox.Show("Verifique o ID do produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            LoadGrid();
        }
    } 

}
