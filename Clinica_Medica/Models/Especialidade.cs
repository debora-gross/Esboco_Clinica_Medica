using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica_Medica.Models
{
    public class Especialidade
    {

        public int id { get; set; }

        public String descricao { get; set; }

        public Especialidade(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public Especialidade()
        {

        }
    }
}
