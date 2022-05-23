using Clinica_Medica.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Medica.DAL
{
    public class ConsultaDAL
    {
        private String connStr = BaseDAL.connStr;

        public int registrarCon(Consulta con)
        {
            int regConsulta = 0;

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = @"INSERT INTO consulta (utente_id, medico_id, especialidade_id, data, hora) VALUES
                                    (@utente_id, @medico_id, @especialidade_id, @data, @hora)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@utente_id", con.utente_id);
                    cmd.Parameters.AddWithValue("@medico_id", con.medico_id);
                    cmd.Parameters.AddWithValue("@especialidade_id", con.especialidade_id);
                    cmd.Parameters.AddWithValue("@data", con.data);
                    cmd.Parameters.AddWithValue("@hora", con.hora);


                    try
                    {
                        regConsulta = cmd.ExecuteNonQuery();

                    }
                    catch (Exception e)
                    {
                    }
                }
            }

            return regConsulta;
        }

        public List<Especialidade> ListarEspecialidades()// o metodo lista empregados vai devolver uma lista
        {
            List<Especialidade> esp = new List<Especialidade>();

            string query = "SELECT * FROM especialidade ORDER BY descricao";

            using (MySqlConnection conn = new MySqlConnection(connStr))//criar a conexão
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))//depois criar o comando. POsso meter o conn aqui ou ali embaixo no cmd.Connection
                {
                    //cmd.Connection = conn;
                    conn.Open();//nao precisa dar um close pois esta dentro do Using
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                esp.Add(new Especialidade(
                                    Int32.Parse(sdr["id"].ToString()),
                                    sdr["descricao"].ToString()

                                    ));
                            }
                        }
                    }
                }
            }

            return esp;
        }

        public List<Consulta> Filtrar_utente_data(string query)
        {
            List<Consulta> cons = new List<Consulta>();

            using (MySqlConnection conn = new MySqlConnection(connStr))//criar a conexão
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))//depois criar o comando. POsso meter o conn aqui ou ali embaixo no cmd.Connection
                {
                    //cmd.Connection = conn;
                    conn.Open();//nao precisa dar um close pois esta dentro do Using
                    
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                cons.Add(new Consulta(
                                    Int32.Parse(sdr["id"].ToString()),
                                    sdr["nome"].ToString(),
                                    sdr["medico"].ToString(),
                                    sdr["especialidade"].ToString(),
                                    sdr.GetDateTime("data").ToString("dd/MM/yyyy"),
                                    sdr["hora"].ToString()

                                    ));
                            }
                        }
                    }
                }
            }

            return cons;
        }

        public int eliminarConsulta(Consulta cons)
        {
            int result = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "DELETE FROM consulta WHERE id=@1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@1", cons.id);
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                        System.Diagnostics.Debug.WriteLine(result);
                    }
                    catch (Exception e)
                    {

                    }

                }
            }
            return result;
        }

        public List<Medico> ListarMedicos()// o metodo lista empregados vai devolver uma lista
        {
            List<Medico> med = new List<Medico>();

            string query = "SELECT * FROM medico ORDER BY nome";

            using (MySqlConnection conn = new MySqlConnection(connStr))//criar a conexão
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))//depois criar o comando. POsso meter o conn aqui ou ali embaixo no cmd.Connection
                {
                    //cmd.Connection = conn;
                    conn.Open();//nao precisa dar um close pois esta dentro do Using
                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                med.Add(new Medico(
                                    Int32.Parse(sdr["id"].ToString()),
                                    sdr["nome"].ToString(),
                                    sdr["contato"].ToString(),
                                    Int32.Parse(sdr["especialidade_id"].ToString())
                                    ));
                            }
                        }
                    }
                }
            }

            return med;
        }

        public Especialidade getEspecialidadeByName(string descricao)
        {
            Especialidade esp = new Especialidade();
            string query = "SELECT * FROM especialidade WHERE descricao=@1";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@1", descricao);

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                esp.id = Int32.Parse(sdr["id"].ToString());
                                esp.descricao = sdr["descricao"].ToString();

                            }
                        }
                    }
                }
            }
            return esp;
        }

        public Medico getMedicoByName(string nome)
        {
            Medico med = new Medico();
            string query = "SELECT * FROM medico WHERE nome=@1";
            //string query2 = "SELECT * FROM medico INNER JOIN especialidade ON medico.especialidade_id = especialidade.id WHERE especialidade_id=@1";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@1", nome);

                    using (MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                med.id = Int32.Parse(sdr["id"].ToString());
                                med.nome = sdr["nome"].ToString();
                                med.contato = sdr["contato"].ToString();
                                med.especialidade_id = Int32.Parse(sdr["especialidade_id"].ToString());
                            }
                        }
                    }
                }
            }
            return med;
        }
        //-----------------------------TENTATIVA DE FILTRAR MEDICO PELA COMBOBOX-----------------------
        
 
            public void ListarMedicosByEspecialidade(ComboBox combo, string displayMember, string valueMember, string Especialidade)// o metodo lista empregados vai devolver uma lista
            {
                //List<Medico> med = new List<Medico>();

                string query = "SELECT medico.id, medico.nome FROM medico " +
                                "INNER JOIN especialidade ON medico.especialidade_id = especialidade.id WHERE especialidade.descricao=@1";
                DataRow dr;


                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@1", Especialidade);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dr = table.NewRow();
                        dr.ItemArray = new object[] { 0, "Selecione..." };
                        table.Rows.InsertAt(dr, 0);
                        combo.DataSource = table;
                        combo.DisplayMember = displayMember;
                        combo.ValueMember = valueMember;

                    }
                }


                //return med;
            }
            //---------------------------------------------------------------------------------

            
            public List<Consulta> ListarConsultas()
            {
                List<Consulta> cons = new List<Consulta>();

                string query = "SELECT consulta.id, utente.nome as Nome, medico.nome AS Medico, especialidade.descricao AS Especialidade, data as Data, hora as Hora FROM consulta" +
                                " INNER JOIN utente ON consulta.utente_id = utente.id" +
                                " INNER JOIN medico ON consulta.medico_id=medico.id" +
                                " INNER JOIN especialidade ON consulta.especialidade_id=especialidade.id ORDER BY data";

                using (MySqlConnection conn = new MySqlConnection(connStr))//criar a conexão
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))//depois criar o comando. POsso meter o conn aqui ou ali embaixo no cmd.Connection
                    {
                        //cmd.Connection = conn;
                        conn.Open();//nao precisa dar um close pois esta dentro do Using
                        using (MySqlDataReader sdr = cmd.ExecuteReader())
                        {
                            if (sdr.HasRows)
                            {
                                while (sdr.Read())
                                {
                                    cons.Add(new Consulta(
                                        Int32.Parse(sdr["id"].ToString()),
                                        sdr["nome"].ToString(),
                                        sdr["medico"].ToString(),
                                        sdr["especialidade"].ToString(),
                                        sdr.GetDateTime("data").ToString("dd/MM/yyyy"),
                                        sdr["hora"].ToString()

                                        ));
                                }
                            }
                        }
                    }
                }

                return cons;
            }
        }
    }  