using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Medica.Models
{
    public class Medico
    {
        public int id { get; set; }
        public String nome { get; set; }

        public String contato { get; set; }

        public int especialidade_id { get; set; }
        

        public Medico(int id, string nome, string contato, int especialidade_id)
        {
            this.id = id;
            this.nome = nome;
            this.contato = contato;
            this.especialidade_id = especialidade_id;
        }

        public Medico()
        {

        }

    }
}
