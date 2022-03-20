using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Prodotti
    {
        public int Idprodotto { get; set; }
        public string Nomeprodotto { get; set; }
        public int Idcategoria { get; set; }
        public int Idnegozio { get; set; }
        public string Immagine { get; set; }
        public int Inofferta { get; set; }
        public double Prezzo { get; set; }
        public string Video { get; set; }
        public int Nascosto { get; set; }
        public string Frescosurgelato { get; set; }
        public int Calorie { get; set; }
        public int Allergeni { get; set; }

        public virtual ICollection<Ingredientiprodotti> Ingrediants { get; private set; }

    }
}
