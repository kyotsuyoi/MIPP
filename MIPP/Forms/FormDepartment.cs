using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MIPP.Forms
{
    public partial class FormDepartment : Form
    {

        DataSet DS = new DataSet();
        Department department = new Department();
        Administrator Ad = new Administrator();
        InputBox IB = new InputBox();
        Midia CI = new Midia();
        int ImageID = 0;

        public FormDepartment()
        {
            InitializeComponent();
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            LoadGrid();
            dgvImage.Visible = false;
        }

        private void FormDepartment_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            if (MessageBox.Show("Deseja fechar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mtbID.Text=="" || mtbID.Text == "0" || txtName.Text == "")
            {
                MessageBox.Show("Verifique ID e nome do departamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (department.Insert(int.Parse(mtbID.Text), txtName.Text, ImageID, cbActivated.Checked) == false) { return; }

            MessageBox.Show("Salvo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "" || mtbID.Text == "0" || txtName.Text == "")
            {
                MessageBox.Show("Verifique ID e nome do departamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (department.Update(int.Parse(mtbID.Text), txtName.Text, ImageID, cbActivated.Checked) == false) { return; }
            
            MessageBox.Show("Alterado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "" || mtbID.Text == "0" || txtName.Text == "")
            {
                MessageBox.Show("Verifique ID e Nome do departamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (department.Delete(int.Parse(mtbID.Text)) == false) { return; }
            }


            if (MessageBox.Show("Deseja excluir este departamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (department.Delete(int.Parse(mtbID.Text)) == false) { return; }
            }
            
            MessageBox.Show("Excluido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadGrid();
        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAll();

            int y;

            try {
                y = dgvDepart.CurrentRow.Index;

                mtbID.Text = (dgvDepart[0, y].Value).ToString();
                txtName.Text = (string)dgvDepart[1, y].Value;
                ImageID = (int)dgvDepart[2, y].Value;
                cbActivated.Checked = (bool)dgvDepart[3, y].Value;

                pbBackground.Image = CI.LoadSpecificImage(ImageID);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvImage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int y;

            try
            {
                y = dgvImage.CurrentRow.Index;
                
                ImageID = (int)dgvImage[0, y].Value;

                pbBackground.Image = CI.LoadSpecificImage(ImageID);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvImage_DoubleClick(object sender, EventArgs e)
        {
            ImageSelected();
        }

        private void dgvImage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ImageSelected();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (mtbID.Text == "")
            {
                MessageBox.Show("Selecione um departamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DS = CI.LoadImageGridByDepart(int.Parse(mtbID.Text));
            dgvImage.DataSource = DS.Tables[0];

            if(dgvImage.RowCount == 0)
            {
                MessageBox.Show("Nenhuma imagem encontrada para este departamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            dgvImage.Visible = true;
            gbDepart.Text = "Imagens";
        }
        
        private void pbBackground_Click(object sender, EventArgs e)
        {
            ImageSelected();
        }

        private void cbActivated_CheckedChanged(object sender, EventArgs e)
        {
            if (cbActivated.Checked == true && (cbActivated.Checked == true && ImageID == 0))
            {
                MessageBox.Show("O departamento esta sem uma imagem de fundo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //cbActivated.Checked = false;
            }

        }

        //
        //>>>>FUNCTIONS<<<<
        //

        private void LoadGrid()
        {
            DS = department.LoadGrid();
            dgvDepart.DataSource = DS.Tables[0];

            dgvDepart.Columns[0].Width = 50;
            dgvDepart.Columns[1].Width = 150;
            dgvDepart.Columns[2].Visible = false;
            dgvDepart.Columns[3].Visible = false;
        }

        private void ClearAll()
        {
            mtbID.Clear();
            txtName.Clear();
            cbActivated.Checked = false;
            pbBackground.Image = null;
            ImageID = 0;
        }

        private void ImageSelected()
        {
            dgvImage.Visible = false;
            gbDepart.Text = "Departamentos";
            if (pbBackground.Image == null) { return; }
            MessageBox.Show("Salve ou altere para gravar esta imagem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
