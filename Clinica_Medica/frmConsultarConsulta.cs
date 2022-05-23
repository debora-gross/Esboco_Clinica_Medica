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
    public partial class frmConsultarConsulta : Form
    {
        Boolean data_checked = false;
        public frmConsultarConsulta()
        {
            InitializeComponent();
        }

        private void frmConsultarConsulta_Load(object sender, EventArgs e)
        {
            LerListaConsultas();

            UtentesDAL dal = new UtentesDAL();
            List<Utente> ut = dal.ListarUtentes();

            Utente ut2 = new Utente();
            ut2.id = 0;
            ut2.nome = "Selecione..";
            ut.Insert(0, ut2);

            cbUtente.DisplayMember = "nome";
            cbUtente.ValueMember = "id";
            cbUtente.DataSource = ut;

            dTPDtConsulta.CustomFormat = " ";
            dTPDtConsulta.Format = DateTimePickerFormat.Custom;
        }

        private void LerListaConsultas()
        {
            ConsultaDAL dal2 = new ConsultaDAL();
            List<Consulta> con = dal2.ListarConsultas();
            dgvVerCons.DataSource = con;
            dgvVerCons.Columns["id"].Visible = false;
            dgvVerCons.Columns["utente_id"].Visible = false;
            dgvVerCons.Columns["medico_id"].Visible = false;
            dgvVerCons.Columns["especialidade_id"].Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbUtente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(dTPDtConsulta.Text);
            if (cbUtente.Text != " " || dTPDtConsulta.CustomFormat != " ")
            {
                int nome_id = (int)cbUtente.SelectedValue;
                string data = (data_checked) ? dTPDtConsulta.Value.ToString("yyyy-MM-dd") : " ";

                ConsultaHandler ch = new ConsultaHandler();
                string query = ch.CriarQuery(nome_id, data);
                System.Diagnostics.Debug.WriteLine(query);

                ConsultaDAL dal = new ConsultaDAL();
                List<Consulta> con = dal.Filtrar_utente_data(query);

                dgvVerCons.DataSource = con;

            }

            data_checked = false;
            //dTPDtConsulta.Value = DateTimePicker.;
            dTPDtConsulta.CustomFormat = " ";
            dTPDtConsulta.Format = DateTimePickerFormat.Custom;

        }

        private void dTPDtConsulta_ValueChanged(object sender, EventArgs e)
        {
            dTPDtConsulta.CustomFormat = "dd/MM/yyyy";
            data_checked = true;


        }

        private void btnEliminarCons_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza deseja cancelar a Consulta?", "Confirme", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                var selectedRow = dgvVerCons.SelectedRows[0].DataBoundItem as Consulta;

                System.Diagnostics.Debug.WriteLine(selectedRow.id);
                ConsultaDAL dal = new ConsultaDAL();
                int result = dal.eliminarConsulta(selectedRow);

                if (result > 0)
                {
                    MessageBox.Show("Consulta cancelada com sucesso!");
                }
                else
                {
                    MessageBox.Show("O cancelamento falhou...");
                }
            }
            LerListaConsultas();
        }
    }
}
