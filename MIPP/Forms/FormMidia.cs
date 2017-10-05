using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace MIPP.Forms
{
    public partial class FormMidia : Form
    {

        DataSet DS = new DataSet();
        Midia CI = new Midia();
        int ID;
        public int CallingDepart = 0;

        public FormMidia()
        {
            InitializeComponent();
        }

        private void FormImage_Load(object sender, EventArgs e)
        {
            var DT = CI.LoadCombo_Department();
            while (DT.Read())
                {
                    cmbDepart.Items.Add(String.Format("{0}", DT[0]));
                }

            LoadDGV();

            if (CallingDepart != 0) LoadGridByDepart();

            axWMP.Visible = false;
        }

        private void FormImage_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //if (MessageBox.Show("Deseja fechar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    this.Close();
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileCheck() == false) { return;  }

                int type;

                if (rbVideo.Checked == false)
                {
                    Image image;

                    if (rbBackground.Checked == true)
                    {
                        image = pbBackground.Image;
                        type = 1;
                    }
                    else
                    {
                        image = pbImage.Image;
                        type = 0;
                    }

                    if (CI.Insert(int.Parse(cmbDepart.Text), txtDescription.Text, type, image, null) == false) { return; }
                }
                else
                {
                    var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vid.mp4");
                    byte[] video = File.ReadAllBytes(strTempFile);

                    if (video.Length > 100000000)
                    {
                        MessageBox.Show("Tamanho máximo do video é de 100MB!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    type = 2;

                    if (CI.Insert(int.Parse(cmbDepart.Text), txtDescription.Text, type, null, video) == false) { return; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            MessageBox.Show("Dados salvos com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDGV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileCheck() == false) { return; }

                int type;

                if (rbVideo.Checked == false)
                {
                    Image image;

                    if (rbBackground.Checked == true)
                    {
                        image = pbBackground.Image;
                        type = 1;
                    }
                    else
                    {
                        image = pbImage.Image;
                        type = 0;
                    }
                    
                    if (CI.Update(ID, int.Parse(cmbDepart.Text), txtDescription.Text, type, image, null) == false) { return; }
                }
                else
                {
                    var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vid.mp4");
                    byte[] video = File.ReadAllBytes(strTempFile);

                    if (video.Length > 100000000)
                    {
                        MessageBox.Show("Tamanho máximo do video é de 100MB!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    type = 2;

                    if (CI.Update(ID, int.Parse(cmbDepart.Text), txtDescription.Text, type, null, video) == false) { return; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Dados alterados com sucesso!", "Altedado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Selecione a imagem!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (CI.Delete(ID) == false) { return; }

            MessageBox.Show("Dados apagados com sucesso!", "Apagado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDGV();
            ClearAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (rbImage.Checked == false && rbBackground.Checked == false && rbVideo.Checked == false)
            {
                MessageBox.Show("Selecione a posição como imagem, como plano de fundo ou  como video!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            OpenFileDialog OFD = new OpenFileDialog();

            if (rbVideo.Checked == true)
            {
                OFD.Filter = "Video Files (*.mp4, * .avi, * .wmv, * .mpg) Then|*.mp4;*.avi;*wmv;*mpg";
            }
            else
            {
                OFD.Filter = "Image Files (*.bmp, * .jpg, * .png) Then|*.bmp;*.jpg;*png";
            }

            axWMP.close();

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                if (rbImage.Checked == true)
                {
                    pbImage.Image = Image.FromFile(OFD.FileName);
                    pbBackground.Image = null;
                }
                else if(rbBackground.Checked == true)
                {
                    pbBackground.Image = Image.FromFile(OFD.FileName);
                    pbImage.Image = null;
                }
                else
                {
                    var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vid.mp4");

                    try
                    {
                        byte[] video = File.ReadAllBytes(OFD.FileName);
                        File.WriteAllBytes(strTempFile, video);
                        axWMP.URL = strTempFile;
                        axWMP.Ctlcontrols.play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        private void rbImage_CheckedChanged(object sender, EventArgs e)
        {
            if (pbImage.Image == null && rbImage.Checked == true && rbBackground.Checked == false)
            {
                pbImage.Image = pbBackground.Image;
                pbBackground.Image = null;
            }
            axWMP.URL = null;

            if (rbImage.Checked == true)
            {
                pbImage.Visible = true;
                pbBackground.Visible = true;
                axWMP.Visible = false;
            }
        }

        private void rbBackground_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBackground.Image == null && rbBackground.Checked == true && rbImage.Checked == false)
            {
                pbBackground.Image = pbImage.Image;
                pbImage.Image = null;
            }
            axWMP.URL = null;

            if (rbBackground.Checked == true)
            {
                pbImage.Visible = true;
                pbBackground.Visible = true;
                axWMP.Visible = false;
            }
        }

        private void rbVideo_CheckedChanged(object sender, EventArgs e)
        {
            pbImage.Image = null;
            pbBackground.Image = null;
            axWMP.URL = null;

            if (rbVideo.Checked == true)
            {
                pbImage.Visible = false;
                pbBackground.Visible = false;
                axWMP.Visible = true;
            }
        }

        private void dgvImage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y;

            try
            {
                y = dgvImage.CurrentRow.Index;

                ID = (int)dgvImage[0, y].Value;
                cmbDepart.Text = (dgvImage[1, y].Value).ToString();
                txtDescription.Text = (string)dgvImage[2, y].Value;
                int type = int.Parse((dgvImage[3, y].Value).ToString());

                if (type == 0) { rbImage.Checked = true; }
                if (type == 1) { rbBackground.Checked = true; }
                if (type == 2) { rbVideo.Checked = true; }

                if (type == 0 || type == 1)
                {
                    Image image = CI.LoadImage(ID, int.Parse(cmbDepart.Text));

                    if (rbBackground.Checked == true)
                    {
                        pbBackground.Image = image;
                    }
                    else
                    {
                        pbImage.Image = image;
                    }
                    axWMP.URL = null;
                }
                else
                {
                    var strTempFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "vid.mp4");

                    try
                    {
                        axWMP.close();
                        byte[] video = CI.LoadVideo(ID, int.Parse(cmbDepart.Text));
                        File.WriteAllBytes(strTempFile, video);
                        axWMP.URL = strTempFile;
                        axWMP.Ctlcontrols.play();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //
        //>>>>FUNCTIONS<<<<
        //

        private void LoadDGV()
        {
            
            dgvImage.DataSource = null;

            DS = CI.LoadGrid();
            if (DS == null) { return; }

            dgvImage.DataSource = DS.Tables[0];

            dgvImage.Columns[0].Width = 50;
            dgvImage.Columns[1].Width = 50;
            dgvImage.Columns[2].Width = 130;
            dgvImage.Columns[3].Width = 50;

        }

        private bool FileCheck()
        {
            if (cmbDepart.Text == "")
            {
                MessageBox.Show("Selecione o departamento!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if ((rbImage.Checked == false && rbBackground.Checked == false && rbVideo.Checked == false) || (pbImage.Image == null && pbBackground.Image == null && axWMP.URL == null))
            {
                MessageBox.Show("Selecione o local da imagem ou o video e depois insira!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtDescription.Text == "")
            {
                MessageBox.Show("Insira uma descrição!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void ClearAll()
        {
            ID = 0;
            rbBackground.Checked = false;
            rbImage.Checked = false;
            txtDescription.Clear();
            cmbDepart.Text = "";
            pbBackground.Image = null;
            pbImage.Image = null;
        }

        public void LoadGridByDepart()
        {
            int x = dgvImage.RowCount;
            while (x != 0) {
                if ((int)dgvImage[1, x-1].Value != CallingDepart)
                {
                    dgvImage.Rows.RemoveAt(x-1);
                    x = dgvImage.RowCount;
                }
                else
                {
                    x --;
                }
            }
        }
        
    }
}
