using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Negozi
    {
        public int Idnegozio { get; set; }
        public string Nomenegozio { get; set; }
        public string Immagine { get; set; }
        public string Imagelogo { get; set; }
        public string Emailpaypal { get; set; }
        public int Prodottiquantita { get; set; }
        public string Valuta { get; set; }
        public int Requestcameriere { get; set; }
        public string Sviluppatore { get; set; }
        public string Supportotecnico { get; set; }
        public string Sitoweb { get; set; }
        public string Versione { get; set; }
        public DateTime? Dataattivazione { get; set; }
        public DateTime? Datascadenza { get; set; }
    }
}
