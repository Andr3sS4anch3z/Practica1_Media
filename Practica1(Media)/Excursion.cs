using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_Media_
{
    public class Excursion
    {
        public int Personas { get; set; }
        public decimal PrecioPorPersona { get; set; }
        public decimal subtotal => PrecioPorPersona * Personas;
        public decimal descuento => subtotal * 0.10m;
        public decimal Total => subtotal - descuento;
    }
}
