using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Utenti
    {
        public int Idutente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Idnegozio { get; set; }
        public int Rank { get; set; }
        public string Ragionesociale { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Partitaiva { get; set; }
        public string Logo { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public string Indirizzo { get; set; }
        public string Cap { get; set; }
        public string Numerocivico { get; set; }
        public string Telefono { get; set; }
        public string Emailpaypal { get; set; }
        public int Dealer { get; set; }
        public string Codiceelettronico { get; set; }
        public int Iddealer { get; set; }
        public string Token { get; set; }
    }
}
