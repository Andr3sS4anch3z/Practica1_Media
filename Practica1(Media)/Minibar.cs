using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1Media;
    public class Minibar
    {
        public int Cantidad {  get; set; }
        public decimal precioUnitario { get; set; }
    
        public decimal subtotal => Cantidad * precioUnitario;
        public decimal ITBS => subtotal * 0.18m;
        public decimal total => subtotal + ITBS;
    }

