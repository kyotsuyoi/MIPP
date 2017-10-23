using System;
using System.Threading;
using System.Windows.Forms;
using MIPP.Forms;

namespace MIPP
{
    public partial class MDI_MIPP : Form
    {
        //string system_version;

        MIPP M;
        FormMidia FM;
        FormShop FSh;
        FormDepartment FD;
        FormScreen FSc;
        FormProduct FP;
        FormBIPP BIPP;
        Thread T;
        bool vCheck = true;
 
        string Version;

        public MDI_MIPP()
        {
            InitializeComponent();
        }

        private void MDI_MIPP_Load(object sender, EventArgs e)
        {
            Version = "0.6 Beta";
            this.Text = this.Text + " " + Version;
            this.WindowState = FormWindowState.Maximized;
            M = new MIPP();

            T = new Thread(ThreadProcess);
            //T.Start();
        }
        private void MDI_MIPP_FromClosing(object sender, EventArgs e)
        {
            vCheck = false;
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
            if (FM != null) { FM.Close(); }
            FM = new FormMidia { MdiParent = this };
            FM.Activate();
            FM.Show();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FP != null) { FP.Close(); }
            FP = new FormProduct { MdiParent = this };
            FP.Activate();
            FP.Show();
        }

        private void telasBIPPPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BIPP != null) { BIPP.Close(); }
            BIPP = new FormBIPP { MdiParent = this };
            BIPP.Activate();
            BIPP.Show();
        }

        private void TelasMIPPPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FSc != null) { FSc.Close(); }
            FSc = new FormScreen { MdiParent = this };
            FSc.Activate();
            FSc.Show();
        }

        private void ThreadProcess()
        {
            while (true)
            {
                var DT = M.LoadShop();

                while (DT.Read())
                {
                    var php = new System.Net.WebClient();
                    string ID = String.Format("{0}", DT[0]);

                    try
                    {
                        if (this.lblAtualization.InvokeRequired)
                        {
                            this.lblAtualization.BeginInvoke((MethodInvoker)delegate ()
                            { this.lblAtualization.Text = "Atualizando loja " + ID; });
                        }
                        else
                        {
                            this.lblAtualization.Text = "";
                        }

                        php.DownloadString("http://192.168.0.221:70/MIPP/insereProdutos.php?Unidade=" + ID);

                        if (vCheck == false) { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }

                this.lblAtualization.BeginInvoke((MethodInvoker)delegate ()
                { this.lblAtualization.Text = "Preços atualizados: " + DateTime.Now; });

                int s = 60000*5;
                while (vCheck == true && s > 0)
                {
                    Thread.Sleep(1000);
                    s -= 1000;
                }
            }
        }

    }
}
