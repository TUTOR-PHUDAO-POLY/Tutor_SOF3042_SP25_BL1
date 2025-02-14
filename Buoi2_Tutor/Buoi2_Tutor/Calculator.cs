using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Tutor
{
    public class Calculator
    {
        public double TinhThuongHaiSoNguyen(int a, int b)
        {
            // check ngoai le 
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)a / b;
        }

        public double TinhCanBacHaiSoNguyen(int a)
        {
            if(a < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return Math.Sqrt(a);
        }
    }
}
