using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRecuperatorio
{
    public partial class frmProyectos : Form
    {
        public frmProyectos()
        {
            InitializeComponent();
        }

        private void btnSP1_Click(object sender, EventArgs e)
        {
            pryVignoloSP1.frmBienvenido objSP1 = new pryVignoloSP1.frmBienvenido();
            objSP1.ShowDialog();
        }

        private void btnSP2_Click(object sender, EventArgs e)
        {
            pryVignoloSP2.FrmPrincipal objSP2 = new pryVignoloSP2.FrmPrincipal();
            objSP2.ShowDialog();
        }

        private void btnSP3_Click(object sender, EventArgs e)
        {
            pryVignoloSP3.frmRepuestos objSP3 = new pryVignoloSP3.frmRepuestos();
            objSP3.ShowDialog();
        }

        private void btnSP4_Click(object sender, EventArgs e)
        {
            prySP4.frmMilanga objSP4 = new prySP4.frmMilanga();
            objSP4.ShowDialog();
        }
    }
}
