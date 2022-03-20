using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Categorie
    {
        public int Idcategoria { get; set; }
        public string Nomecategoria { get; set; }
        public string Immagine { get; set; }
        public int Idnegozio { get; set; }
    }
}
