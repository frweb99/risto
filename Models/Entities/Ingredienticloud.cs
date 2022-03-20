using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Ingredienticloud
    {
        public int Idingrediente { get; set; }
        public string Nome { get; set; }
        public int Surgelatofresco { get; set; }
        public int Idnegozio { get; set; }
        public int Allergeni { get; set; }
    }
}
