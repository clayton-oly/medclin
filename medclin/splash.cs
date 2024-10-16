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
    public partial class splash : Form
    {
        public splash() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            frmPrincipal princ = new frmPrincipal();
            princ.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
