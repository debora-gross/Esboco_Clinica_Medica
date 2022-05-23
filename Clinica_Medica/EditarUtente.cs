using Clinica_Medica.DAL;
using Clinica_Medica.Handlers;
using Clinica_Medica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Medica
{
    public partial class EditarUtente : Form
    {
        public EditarUtente()
        {
            InitializeComponent();
        }

        int id = 0;
        //string referencia = "";

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            UtentesHandler uh = new UtentesHandler();
            (int codErro, Utente ut) = uh.ValidarUte(tbNome.Text,
                                tbUtente.Text,
                                dtpDN.Value,
                                tbMorada.Text,
                                tbContato.Text,
                                tbNif.Text
                                );

            
            // ---------------------------------------------------------------------

            UtentesDAL dal = new UtentesDAL();
            ut.id = this.id;
            int registo = dal.AtualizarUte(ut);



            if (registo > 0)
            {
                MessageBox.Show("Registo guardado na base de dados com sucesso!");
                this.Close();
                //LimparFormulario();
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou.");
            }

            //this.Close();
        }

        public void setValores(Utente ut)
        {
            this.id = ut.id;

            tbNome.Text = ut.nome;
            tbUtente.Text = ut.nUtente;
            dtpDN.Text = ut.dt_nasc.ToString();
            tbMorada.Text = ut.morada;
            tbContato.Text = ut.contato;
            tbNif.Text = ut.nif;

            //this.referencia = emp.referencia;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpDN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditarUtente_Load(object sender, EventArgs e)
        {
            
        }
    }
}
