using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medclin
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }
        private void FecharFormulariosFilhos() {
            for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 1; intIndex--)
            {
                if (Application.OpenForms[intIndex] != this)
                    Application.OpenForms[intIndex].Close();
            }
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized; //para mininizar o programa =D
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) {
            FecharFormulariosFilhos();
            frmCadastroPaciente casdP = new frmCadastroPaciente();
            casdP.MdiParent = this;
            logocentral.Visible = false;
            panel3.Visible = false;
            casdP.Show();
           
            

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e) {
            FecharFormulariosFilhos();
            frmCadastroPaciente casdP = new frmCadastroPaciente();
            casdP.MdiParent = this;
            logocentral.Visible = false;
            panel3.Visible = false;
            casdP.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e) {
            FecharFormulariosFilhos();
            frmCadastroMedico cadasM = new frmCadastroMedico();
            cadasM.MdiParent = this;
            logocentral.Visible = false;
            panel3.Visible = false;
            cadasM.Show();
            

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e) {
            FecharFormulariosFilhos();
            frmCadastroMedico cadasM = new frmCadastroMedico();
            cadasM.MdiParent = this;
            logocentral.Visible = false;
            panel3.Visible = false;
            cadasM.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e) {
            FecharFormulariosFilhos();
            frmCadastroAgenda agend = new frmCadastroAgenda();
            agend.MdiParent = this;
            logocentral.Visible = false;
            panel3.Visible = false;
            agend.Show();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e) {
            FecharFormulariosFilhos();
            logocentral.Visible = true;
            panel3.Visible = true;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e) {
            FecharFormulariosFilhos();
            sobre sob = new sobre();
            sob.MdiParent = this;
            logocentral.Visible = false;
            panel3.Visible = false;
            sob.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
