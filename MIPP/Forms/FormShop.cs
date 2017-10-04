using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPP.Forms
{
    public partial class FormShop : Form
    {
        Shop S = new Shop();
        DataSet DS = new DataSet();
        Administrator Ad = new Administrator();
        InputBox IB = new InputBox();
        public FormShop()
        {
            InitializeComponent();
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "" || mtbID.Text == "0" || txtName.Text == "")
            {
                MessageBox.Show("Verifique ID e Nome da loja!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (S.Insert(int.Parse(mtbID.Text), txtName.Text, cbActivated.Checked) == true) { return; }

            MessageBox.Show("Salvo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "" || mtbID.Text == "0" || txtName.Text == "")
            {
                MessageBox.Show("Verifique ID e Nome da loja!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (S.Update(int.Parse(mtbID.Text), txtName.Text, cbActivated.Checked) == false) { return; }

            MessageBox.Show("Alterado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "" || mtbID.Text == "0" || txtName.Text == "")
            {
                MessageBox.Show("Verifique ID e Nome da loja!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (S.Delete(int.Parse(mtbID.Text)) == false) { return; }
            }


            if (MessageBox.Show("Deseja apagar este departamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (S.Delete(int.Parse(mtbID.Text)) == false) { return; }
            }

            MessageBox.Show("Excluido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();


        }

        private void dgvShop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y;

            try
            {
                y = dgvShop.CurrentRow.Index;

                mtbID.Text = (dgvShop[0, y].Value).ToString();
                txtName.Text = (string)dgvShop[1, y].Value;

                cbActivated.Checked = (bool)dgvShop[2, y].Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //
        //>>>>FUNCTIONS<<<<
        //

        private void LoadGrid()
        {
            DS = S.LoadGrid();
            dgvShop.DataSource = DS.Tables[0];

            dgvShop.Columns[0].Width = 50;
            dgvShop.Columns[1].Width = 150;
            dgvShop.Columns[2].Visible = false;
        }
    }
}
