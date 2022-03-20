using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Sessioni
    {
        public int Idsessione { get; set; }
        public string New { get; set; }
        public string Token { get; set; }
        public int Iddispositivolingua { get; set; }
        public int Idnegozio { get; set; }
        public string Lingua { get; set; }
    }
}
