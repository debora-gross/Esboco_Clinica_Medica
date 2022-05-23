using Clinica_Medica.DAL;
using Clinica_Medica.Handlers;
using Clinica_Medica.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Medica
{
    public partial class frmInserirConsulta : Form
    {
        //private String connStr = "datasource=192.168.1.70;port=3306;username=root;password=aaa123;database=Clinica_Medica;SslMode=none";
        private int _id = 0;
        private int _idMed = 0;
        private int _idEsp = 0;
        public frmInserirConsulta()
        {
            InitializeComponent();
        }

        private void frmInserirConsulta_Load(object sender, EventArgs e)
        {
            UtentesDAL dal = new UtentesDAL();
            List<Utente> ut = dal.ListarUtentes();

            cbUtente.Items.Add("Selecione...");

            foreach (var item in ut)
            {
                cbUtente.Items.Add(item.nome);
            }
            cbUtente.SelectedIndex = 0;


            ConsultaDAL dal2 = new ConsultaDAL();
            List<Medico> med = dal2.ListarMedicos();

            cbMedico.Items.Add("Selecione...");

            foreach (var item in med)
            {
                cbMedico.Items.Add(item.nome);
            }
            cbMedico.SelectedIndex = 0;

            ConsultaDAL dal3 = new ConsultaDAL();
            List<Especialidade> esp = dal3.ListarEspecialidades();

            cbEspecialidade.Items.Add("Selecione...");

            foreach (var item in esp)
            {
                cbEspecialidade.Items.Add(item.descricao);
            }
            cbEspecialidade.SelectedIndex = 0;
            //cbEspecialidade_SelectedIndexChanged(null, null);

            dTPdtConsulta.CustomFormat = " ";
            dTPdtConsulta.Format = DateTimePickerFormat.Custom;

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            String ut = cbUtente.Text;

            UtentesDAL dal = new UtentesDAL();

            Utente ut_dados = dal.getUtenteByName(ut);
            lbNome.Text = ut_dados.nome;
            lbUtente.Text = ut_dados.nUtente;
            lbDtNasc.Text = ut_dados.dt_nasc;
            lbContato.Text = ut_dados.contato;
            //lbNIF.Text = ut_dados.nif;
            

            _id = ut_dados.id;

            //pn.Visible = true;
        }

        
        private void btnAgendar_Click(object sender, EventArgs e)
        {
             /*ConsultaHandler ch = new ConsultaHandler();
            (int codErro, Consulta con) = ch.ValidarCons(cbUtente.Text,
                                cbEspecialidade.Text,
                                cbMedico.Text,
                                dTPdtConsulta.Value,
                                cbHora
                                );*/

            if (cbUtente.Text.Length == 0 || cbEspecialidade.Text.Length == 0 || cbMedico.Text.Length == 0)
            {
                MessageBox.Show("Selecione o Utente, o Médico e a Especialidade...");
                return;
            }

            if (dTPdtConsulta.Value < DateTime.Now)
            {
                MessageBox.Show("Insira uma data futura...");
                return;
            }

            Consulta con = new Consulta();
            
            con.utente_id = _id;

            //alimentar a especialidade, medico com os IDs e a data e hora:

            String esp = cbEspecialidade.Text;
            //String espMedica = cbEspecialidade.SelectedItem()
            String med = cbMedico.Text;

            ConsultaDAL dal = new ConsultaDAL();

            Especialidade esp_dados = dal.getEspecialidadeByName(esp);
            _idEsp = esp_dados.id;
            con.especialidade_id = _idEsp;

            Medico med_dados = dal.getMedicoByName(med);
            _idMed = med_dados.id;
            con.medico_id = _idMed;

            string dt_conStr = dTPdtConsulta.Value.ToString("yyyy-MM-dd");
            con.data = dt_conStr;

            con.hora = cbHora.Text;



            //int numReg = dal.checkConsultaExiste(proc.empregado_id, proc.mes, proc.ano);

            int registro = 0;
            //string mensagem = "";

            /*if (numReg > 0)
            {
                //registro = dal.Update(proc);
                //mensagem = (registro > 0) ? "Atualização na BD realizada com sucesso!" : "A atualização na BD falhou...";
            }
            else*/
            registro = dal.registrarCon(con);
            //mensagem = (registro > 0) ? "Agendamento realizado com sucesso!" : "Registro na BD falhou...";

            if (registro > 0)
            {
                MessageBox.Show("Agendamento realizado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("O registro na BD falhou...");
            }

            //MessageBox.Show(mensagem);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecialidade.SelectedIndex != 0)
            {
                ConsultaDAL dal = new ConsultaDAL();
                dal.ListarMedicosByEspecialidade(cbMedico, "nome", "id", cbEspecialidade.SelectedItem.ToString());
            }
        }

        private void dTPdtConsulta_ValueChanged(object sender, EventArgs e)
        {
            dTPdtConsulta.CustomFormat = "dd/MM/yyyy";
        }
    }
}
