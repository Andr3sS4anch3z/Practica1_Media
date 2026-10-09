using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_Media_
{
    public class Viaje
    {
        public int Pasajeros { get; set; }
        public bool Nocturno { get; set; }
        public decimal subtotal => Pasajeros * 25m;
        public decimal recargo => Nocturno ? subtotal : 0m;
        public decimal Total => recargo;

        

         

    }
}
