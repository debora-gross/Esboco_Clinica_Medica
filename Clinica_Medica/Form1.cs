using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Medica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInserirUtente ie = new frmInserirUtente();
            ie.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarUtente cu = new frmConsultarUtente();
            cu.ShowDialog();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInserirConsulta ic = new frmInserirConsulta();
            ic.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarConsulta cc = new frmConsultarConsulta();
            cc.ShowDialog();
        }
    }
}
