using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Dispositivi
    {
        public int Iddispositivo { get; set; }
        public int Numerodispositivo { get; set; }
        public string Lingua { get; set; }
        public string Tipologia { get; set; }
        public string Pagamento { get; set; }
        public int Numeroprodotti { get; set; }
        public int Idnegozio { get; set; }
        public string Codiceautorizzazione { get; set; }
        public string Nominativo { get; set; }
    }
}
