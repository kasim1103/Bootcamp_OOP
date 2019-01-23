using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp.OOP
{
    abstract class Bangun2D
    {
        public abstract double HitungLuas();

        public void CetakLuas(string namabangun)
        {
            Console.WriteLine("Luas " + namabangun + "\t = " + HitungLuas());
        }
    }
}
