using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Ordiniprodotti
    {
        public int Idordineprodotti { get; set; }
        public string Nomeprodotto { get; set; }
        public string Ingredientinondesiderati { get; set; }
        public int Idordine { get; set; }
        public int Idnegozio { get; set; }
        public int Completato { get; set; }
        public int? Idprodotto { get; set; }
        public int Quantita { get; set; }
    }
}
