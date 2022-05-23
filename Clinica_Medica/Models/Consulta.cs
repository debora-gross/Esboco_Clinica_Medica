using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica_Medica.Models
{
    public class Consulta
    {
        public int id { get; set; }
        public int utente_id { get; set; }
        public String Utente { get; set; }
        public int medico_id { get; set; }
        public String Medico { get; set; }
        public int especialidade_id { get; set; }
        public String Especialidade { get; set; }
        public String data { get; set; }
        public String hora { get; set; }

        public Consulta(int id, int utente_id, int medico_id, int especialidade_id, string data, string hora)
        {
            this.id = id;
            this.utente_id = utente_id;
            this.medico_id = medico_id;
            this.especialidade_id = especialidade_id;
            this.data = data;
            this.hora = hora;
        }

        public Consulta(int id, String utente, String medico, String especialidade, string data, string hora)
        {
            this.id = id;
            this.Utente = utente;
            this.Medico= medico;
            this.Especialidade = especialidade;
            this.data = data;
            this.hora = hora;
        }

        public Consulta(){}
    }
}
 
