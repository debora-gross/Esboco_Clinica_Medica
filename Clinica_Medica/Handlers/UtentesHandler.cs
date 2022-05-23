using Clinica_Medica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinica_Medica.Handlers
{
    class UtentesHandler
    {
        public (int, Utente) ValidarUte(string nome, string nUtente, System.DateTime dt_nasc, string morada, string contato, string nif)
        {
            int codErro = 0;
            Utente ut = new Utente();

            
            if (dt_nasc > DateTime.Now)
            {
                return (1, null);
            }

            

            if (!Int32.TryParse(nUtente.ToString(), out int numUtente) || nUtente.Length != 9)
            {
                return (2, null);
            }

            if (!Int32.TryParse(nif.ToString(), out int numNif) || nUtente.Length != 9)
            {
                return (3, null);
            }

            string dt_nascStr = dt_nasc.ToString("yyyy-MM-dd");
            
            
            ut.nome = nome;
            ut.nUtente = nUtente;
            ut.dt_nasc = dt_nascStr;
            ut.morada = morada;
            ut.contato = contato;
            ut.nif = nif;

            return (codErro, ut);
        }
    }
}
