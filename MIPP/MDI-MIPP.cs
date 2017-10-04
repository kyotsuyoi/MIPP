using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIPP.CommonClasses;
using MIPP.Forms;

namespace MIPP
{
    public partial class MDI_MIPP : Form
    {
        //string system_version;
        Connection c = new Connection();

        FormImage FI;
        FormShop FSh;
        FormDepartment FD;
        FormScreen FSc;
        FormProduct FP;

        string Version;

        public MDI_MIPP()
        {
            InitializeComponent();
        }

        private void MDI_MIPP_Load(object sender, EventArgs e)
        {
            Version = "0.5 Beta";
            this.Text = this.Text + " " + Version;
            this.WindowState = FormWindowState.Maximized;
            try
            {
                c.cmd.Connection = c.Connect;
                c.Connect.Open();
                //c.cmd.CommandText = "SELECT system_version FROM system_checks WHERE id = '2'";
                //system_version = (string)c.cmd.ExecuteScalar();
                //MessageBox.Show(""+s, "Teste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! " + ex.Message);
            }
            finally
            {
                c.Connect.Close();
                c.Connect.Dispose();
            }
        }
        
        private void DepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FD != null) { FD.Close(); }
            FD = new FormDepartment { MdiParent = this };
            FD.Activate();
            FD.Show();
        }

        private void LojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FSh != null) { FSh.Close(); }
            FSh = new FormShop { MdiParent = this };
            FSh.Activate();
            FSh.Show();
        }

        private void ImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FI != null) { FI.Close(); }
            FI = new FormImage { MdiParent = this };
            FI.Activate();
            FI.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FP != null) { FP.Close(); }
            FP = new FormProduct { MdiParent = this };
            FP.Activate();
            FP.Show();
        }

        private void TelasMIPPPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FSc != null) { FSc.Close(); }
            FSc = new FormScreen { MdiParent = this };
            FSc.Activate();
            FSc.Show();
        }
    }
}
