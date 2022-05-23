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
    public partial class frmInserirUtente : Form
    {
        public frmInserirUtente()
        {
            InitializeComponent();
        }

         private void btnInserir_Click(object sender, EventArgs e)
        {
            UtentesHandler uh = new UtentesHandler();
            (int codErro, Utente ut) = uh.ValidarUte(tbNome.Text,
                                tbUtente.Text,
                                dtpDN.Value,
                                tbMorada.Text,
                                tbContato.Text,
                                tbNif.Text
                                );


            if (codErro == 1)
            {
                MessageBox.Show("A Data de Nascimento deve ser anterior ao dia de hoje!Verifique!");
                dtpDN.Focus();
                return;
            }

            if (codErro == 2)
            {
                MessageBox.Show("Número de Utente inválido! Digite 9 dígitos!");
                tbUtente.Clear();
                tbUtente.Focus();
                return;
            }

            if (codErro == 3)
            {
                MessageBox.Show("Número de NIF inválido! Digite 9 dígitos!");
                tbNif.Clear();
                tbNif.Focus();
                return;
            }
            // ---------------------------------------------------------------------


            //Utente ut = new Utente();
            UtentesDAL dal = new UtentesDAL();
            int registo = dal.InserirUte(ut);// insere na DB apos ter feitos todas as validações de dados



            if (registo > 0)
            {
                MessageBox.Show("Registo guardado na base de dados com sucesso!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("O registo na base de dados falhou...");
            }

            //this.Close();

        }
        private void LimparFormulario()
        {
            tbNome.Text = "";
            tbUtente.Text = "";
            dtpDN.Text = "";
            tbMorada.Text = "";
            tbContato.Text = "";
            tbNif.Text = "";
        }

        private void InserirEmpregado_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInserirUtente_Load(object sender, EventArgs e)
        {
            dtpDN.CustomFormat = " ";
            dtpDN.Format = DateTimePickerFormat.Custom;
        }

        private void dtpDN_ValueChanged(object sender, EventArgs e)
        {
            dtpDN.CustomFormat = "dd/MM/yyyy";
        }
    }
}

