using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Ordini
    {
        public int Idordine { get; set; }
        public int? Iddispositivo { get; set; }
        public int Ordinecompleto { get; set; }
        public int Ordineconfermato { get; set; }
        public int Ordinepagato { get; set; }
        public float Totaleprezzo { get; set; }
        public int Letto { get; set; }
        public int? Numerodispositivo { get; set; }
        public int Ordinecucina { get; set; }
        public DateTime? Data { get; set; }
        public int Idnegozio { get; set; }
        public int Passatosusmartphone { get; set; }
        public int Richiestapassaggiosmartphone { get; set; }
        public string Token { get; set; }
    }
}
