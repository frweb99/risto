using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Licenze
    {
        public int Idlicenza { get; set; }
        public string Serial { get; set; }
        public int Durata { get; set; }
        public int Consegnata { get; set; }
        public int Utilizzata { get; set; }
        public string Sviluppatore { get; set; }
        public string Supportotecnico { get; set; }
        public string Sitoweb { get; set; }
        public int Iddealer { get; set; }
    }
}
