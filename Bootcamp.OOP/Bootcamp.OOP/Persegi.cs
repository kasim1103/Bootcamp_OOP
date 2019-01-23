using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    class Persegi : Bangun2D
    {
        private double sisi;

        public Persegi(double s)
        {
            this.sisi = s;
        }

        public override double HitungLuas()
        {
            return(sisi * sisi);
        }
    }
}
