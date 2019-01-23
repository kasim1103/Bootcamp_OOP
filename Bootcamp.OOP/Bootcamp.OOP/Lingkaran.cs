using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Lingkaran : Bangun2D
    {
        private double jari;

        public Lingkaran(double j)
        {
            this.jari = j;
        }

        public override double HitungLuas()
        {
            return(3.14 * jari * jari);
        }
    }
}
