using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Immagini
    {
        public int Idimmagine { get; set; }
        public string Nome { get; set; }
        public string Link { get; set; }
        public int Idutente { get; set; }
        public int Idnegozio { get; set; }
    }
}
