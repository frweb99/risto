using System;
using System.Collections.Generic;

namespace RCommerce.Models.Entities
{
    public partial class Settings
    {
        public int Id { get; set; }
        public int Idnegozio { get; set; }
        public string Valuta { get; set; }
        public string Imagelogo { get; set; }
        public int Prodottiquantita { get; set; }
        public int? Idcategoriapredefinita { get; set; }
        public int Requestcameriere { get; set; }
        public string Sviluppatore { get; set; }
        public string Supportotecnico { get; set; }
        public string Sitoweb { get; set; }
        public string Serial { get; set; }
        public string Sitowebsoftware { get; set; }
        public string Emailpaypal { get; set; }
        public string Actionpaypal { get; set; }
    }
}
