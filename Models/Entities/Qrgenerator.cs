using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Qrgenerator
    {
        public int Id { get; set; }
        public string Titolo { get; set; }
        public string Descrizione { get; set; }
        public int Numerodispositivo { get; set; }
        public int Idnegozio { get; set; }
        public int? Iddispositivo { get; set; }
    }
}
