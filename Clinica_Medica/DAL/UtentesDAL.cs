using Clinica_Medica.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica_Medica.DAL
{
    class UtentesDAL
    {
        private String connStr = BaseDAL.connStr;

        public int InserirUte(Utente ut)//metodo que vai guardar na DB
        {
            int registro = 0;
            string query = "INSERT INTO utente (nome, nUtente, dt_nasc, morada, contato, nif)" +
                            "VALUES (@nome, @nUtente, @dt_nasc, @morada, @contato, @nif)";

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();// open é um metodo que esta dentro do MySqlConnection

                    cmd.Parameters.AddWithValue("@nome", ut.nome);
                    cmd.Parameters.AddWithValue("@nUtente", ut.nUtente);
                    cmd.Parameters.AddWithValue("@dt_nasc", ut.dt_nasc);
                    cmd.Parameters.AddWithValue("@morada", ut.morada);
                    cmd.Parameters.AddWithValue("@contato", ut.contato);
                    cmd.Parameters.AddWithValue("@nif", ut.nif);

                    try
                    {
                        registro = cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message, e);
                    }
                }
            }
            return registro;
        }

        public Utente getUtenteByName(string nome)
        {
            Utente ut = new Utente();
            string query = "SELECT * FROM utente WHERE nome=@1";

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
                                ut.id = Int32.Parse(sdr["id"].ToString());
                                ut.nome = sdr["nome"].ToString();
                                ut.nUtente = sdr["nUtente"].ToString();
                                ut.dt_nasc = sdr.GetDateTime("dt_nasc").ToString("dd/MM/yyyy");
                                ut.contato = sdr["contato"].ToString();
                                ut.nif = sdr["nif"].ToString();
                            }
                        }
                    }
                }
            }
            return ut;
        }

        public int AtualizarUte(Utente ut)
        {
            int registro = 0;
            string query = @"UPDATE utente SET nome=@nome, nUtente=@nUtente, dt_nasc=@dt_nasc, morada=@morada, contato=@contato, nif=@nif WHERE id=@id";


            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", ut.id);
                    cmd.Parameters.AddWithValue("@nome", ut.nome);
                    cmd.Parameters.AddWithValue("@nUtente", ut.nUtente);
                    cmd.Parameters.AddWithValue("@dt_nasc", ut.dt_nasc);
                    cmd.Parameters.AddWithValue("@morada", ut.morada);
                    cmd.Parameters.AddWithValue("@contato", ut.contato);
                    cmd.Parameters.AddWithValue("@nif", ut.nif);
                    

                    try
                    {
                        registro = cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        //throw new Exception(e.Message, e);
                    }
                }
            }

            return registro;
        }

        public List<Utente> ListarUtentes()
        {
            List<Utente> ut = new List<Utente>();

            string query = "SELECT * FROM utente ORDER BY nome";

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
                                ut.Add(new Utente(
                                    Int32.Parse(sdr["id"].ToString()),
                                    sdr["nome"].ToString(),
                                    sdr["nUtente"].ToString(),
                                    //sdr["dt_nasc"].ToString(),
                                    sdr.GetDateTime("dt_nasc").ToString("dd/MM/yyyy"),
                                    sdr["morada"].ToString(),
                                    sdr["contato"].ToString(),
                                    sdr["nif"].ToString()

                                    ));
                            }
                        }
                    }
                }
            }

            return ut;
        }

        public int eliminarUtente(Utente ut)
        {
            int result = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "DELETE FROM utente WHERE id=@1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@1", ut.id);
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
    }
}
