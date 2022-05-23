using Clinica_Medica.DAL;
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
    public partial class frmConsultarUtente : Form
    {
        public frmConsultarUtente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvConsUte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultarUtente_Load(object sender, EventArgs e)
        {
                LerLista();
        }

            private void LerLista()
            {
                UtentesDAL dal = new UtentesDAL();
                List<Utente> ut = dal.ListarUtentes();
                dgvConsUte.DataSource = ut;
                dgvConsUte.Columns["id"].Visible = false;
                dgvConsUte.Columns["nome"].HeaderCell.Value = "Nome";
                dgvConsUte.Columns["nUtente"].HeaderCell.Value = "Número Utente";
                dgvConsUte.Columns["dt_nasc"].HeaderCell.Value = "Data Nascimento";
                dgvConsUte.Columns["morada"].HeaderCell.Value = "Morada";
                dgvConsUte.Columns["contato"].HeaderCell.Value = "Contato";
                dgvConsUte.Columns["nif"].HeaderCell.Value = "NIF";

        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = dgvConsUte.SelectedRows[0].DataBoundItem as Utente;
                EditarUtente eu = new EditarUtente();
                eu.setValores(selectedRow);
                eu.ShowDialog();
                //Atualizar a DGV com as alteraçoes/updates
                LerLista();

            }
            catch (Exception ex)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza que quer eliminar o registro?", "Confirme", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var selectedRow = dgvConsUte.SelectedRows[0].DataBoundItem as Utente;

                UtentesDAL dal = new UtentesDAL();
                int result = dal.eliminarUtente(selectedRow);

                if (result > 0)
                {
                    MessageBox.Show("Eliminação feita com sucesso!");
                }
                else
                {
                    MessageBox.Show("A eliminação falhou...");
                }
            }
            LerLista();
        }
    }
}
