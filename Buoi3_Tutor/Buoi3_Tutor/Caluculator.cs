using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Tutor
{
    public class Caluculator
    {
        // viet ham tinh can bac hai...
        public double TinhCanBacHai(int number)
        {
            // Bat buoc phai xu ly ngoai le
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Sqrt(number);
        }
    }
}
