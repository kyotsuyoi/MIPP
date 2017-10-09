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

        public FormBIPP()
        {
            InitializeComponent();
        }
        private void FormBIPP_Load(object sender, EventArgs e)
        {
            var DT = Pr.LoadCombo_Department();

            while (DT.Read())
            {
                cmbDepart.Items.Add(String.Format("{0}", DT[0]));
            }
            LoadGrid();
        }
        private void LoadGrid()
        {
            DS = Pr.LoadGrid();
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
            dgvProduct.DataSource = DS.Tables[0];
        }

        private void btnSearchDepart_Click(object sender, EventArgs e)
        {
            if (cmbDepart.Text == "")
            {
                MessageBox.Show("Selecione o Departamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                mtbID.Text = (dgvProduct[0, y].Value).ToString();
                txtDescription.Text = (string)dgvProduct[1, y].Value;
                cmbDepart.Text = (dgvProduct[2, y].Value).ToString();
                pbPhoto.Image = Pr.LoadImage(int.Parse(mtbID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellCClick(object sender, DataGridViewCellEventArgs e)
        {
            //fazer
        }
    } 
}
