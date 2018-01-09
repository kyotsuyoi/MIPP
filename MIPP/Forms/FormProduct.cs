using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MIPP.Forms
{
    public partial class FormProduct : Form
    {
        DataSet DS = new DataSet();
        Product Pr = new Product();
        Department De = new Department();
        Administrator Ad = new Administrator();
        InputBox IB = new InputBox();

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            var DT = De.LoadCombo_Department();

            while (DT.Read())
            {
                cmbDepart.Items.Add(String.Format("{0}", DT[0]));
            }
            ClearAll();
            LoadGrid();
        }

        private void dgvImage_CellClick(object sender, DataGridViewCellEventArgs e)
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
                txtEAN.Text = (string)dgvProduct[3, y].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LoadGrid()
        {
            DS = Pr.LoadGrid();
            dgvProduct.DataSource = DS.Tables[0]; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(mtbID.Text == "" || txtDescription.Text == "" || cmbDepart.Text == "")
            {
                MessageBox.Show("Verifique os campos obrigatórios","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Pr.Insert(int.Parse(mtbID.Text), txtDescription.Text, int.Parse(cmbDepart.Text), txtEAN.Text) == false) { return; }

            MessageBox.Show("Salvo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text == "" || cmbDepart.Text == "")
            {
                MessageBox.Show("Verifique os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Pr.Update(int.Parse(mtbID.Text), txtDescription.Text, int.Parse(cmbDepart.Text), pbPhoto.Image, txtEAN.Text) == false) { return; }

            MessageBox.Show("Alterado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "") 
            {
                MessageBox.Show("Verifique os campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var DT = Ad.LoadPassword();

            DT.Read();
            string value = String.Format("{0}", DT[0]);
            string value1 = "";
            if (IB.InputBoxFunction("Insert a password", "Password:", ref value1) == DialogResult.OK)
            {
                if (value != value1)
                {
                    MessageBox.Show("Wrong Pass!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                return;
            }

            if (MessageBox.Show("Deseja apagar este produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Pr.Delete(int.Parse(mtbID.Text)) == false) { return; }
            }
            LoadGrid();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            if(mtbID.Text == "")
            {
                MessageBox.Show("Insira o ID", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchID(int.Parse(mtbID.Text));           
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            mtbID.Text = "";
            txtDescription.Clear();
            cmbDepart.Text = "";
            lblDepart.Text = "";
            pbPhoto.Image = null;
            txtEAN.Text = "";
            LoadGrid();
        }

        private void CmbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepart.Text=="")
            {
                lblDepart.Text = "";
                return;
            }
            lblDepart.Text = De.LoadDepart(int.Parse(cmbDepart.Text));
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files (*.bmp, * .jpg, * .png) Then|*.bmp;*.jpg;*png";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pbPhoto.Image = Image.FromFile(OFD.FileName);
            }
        }

        private void btnEAN_Click(object sender, EventArgs e)
        {
            if (txtEAN.Text == "")
            {
                MessageBox.Show("Insira a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DS = Pr.LoadGrid_SearchEAN(Int64.Parse(txtEAN.Text));
            dgvProduct.DataSource = DS.Tables[0];
        }
    }
}
