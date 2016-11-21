using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingChallenge.Models
{
    public class DetalleModel
    {
        public string descripcion { get; set; }
        public string detalle { get; set; }
        public string moneda { get; set; }
        public string simbolo { get; set; }
        public string tipo { get; set; }
    }
}