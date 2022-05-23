using Clinica_Medica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica_Medica.Handlers
{
    public class ConsultaHandler
    {
        public (int, Consulta) ValidarCons(int utente_id, int medico_id, int especialidade_id, System.DateTime data, string hora)
        {
            int codErro = 0;
            Consulta con = new Consulta();

            if (data < DateTime.Now)
            {
                return (1, null);
            }

            string dt_conStr = data.ToString("yyyy-MM-dd");
            


            //con.id = id;
            con.utente_id = utente_id;
            con.medico_id = medico_id;
            con.especialidade_id = especialidade_id;
            con.data = dt_conStr;
            con.hora = hora;

            return (codErro, con);
        }

        public string CriarQuery(int nome_id, String data)
        {
            //var date = Convert.ToDateTime(data);
            //date.ToString("yyyy-MM-dd");
            
            string query = "SELECT consulta.id, utente.nome as Nome, medico.nome AS Medico, especialidade.descricao AS Especialidade, data as Data, hora as Hora FROM consulta" +
                            " INNER JOIN utente ON consulta.utente_id = utente.id" +
                            " INNER JOIN medico ON consulta.medico_id=medico.id" +
                            " INNER JOIN especialidade ON consulta.especialidade_id=especialidade.id WHERE 1=1";
            if (nome_id > 0)
            {
                query += " AND utente_id=" + nome_id;
            }
            
            if (!data.Contains(" "))
            {
                query += " AND data=\"" + data + "\"";
            }

            query += " ORDER BY data";

            return query;
        }
    }
}
