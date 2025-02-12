using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Tutor
{
    public class Caluclator
    {
        // 4 ham tinh tong, hieu, tich, thuong 
        public int TinhTong(int a, int b)
        {
            return a + b;
        }
        public int TinhHieu(int a, int b)
        {
            return a - b;
        }
        public int TinhNhan(int a, int b)
        {
            return a * b;
        }
        public double TinhChia(int a, int b)
        {
            return (double)a / b;
        }
    }
}
