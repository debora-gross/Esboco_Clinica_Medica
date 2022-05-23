using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica_Medica.Models
{
    public class Utente//se eu não meter public, por default a classe é private
    {
        
        public int id { get; set; }

        public String nome { get; set; }
        public String nUtente { get; set; }

        //public String NumeroUtente { }
        public String morada { get; set; }

        public String dt_nasc { get; set; }
        public String contato { get; set; }
        public String nif { get; set; }

        public Utente(int id, string nome, string nUtente, string dt_nasc, string morada, string contato, string nif)
        {
            this.id = id;
            this.nome = nome;
            this.nUtente = nUtente;
            this.dt_nasc = dt_nasc;
            this.morada = morada;
            this.contato = contato;
            this.nif = nif;
        }

        public Utente()
        {

        }


    }
}
