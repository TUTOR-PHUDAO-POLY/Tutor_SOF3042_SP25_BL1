using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Tutor
{
    public class KhachHang
    {
        //Tạo class KhachHang gồm
        //các thuộc tính ma - String, ten - String,
        //tuoi - int, email - String, soDienThoai - String.
        private String ma;
        private String ten;
        private int tuoi;
        private String email;
        private String sdt;

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Email { get => email; set => email = value; }
        public string Sdt { get => sdt; set => sdt = value; }

        public KhachHang(string ma, string ten, int tuoi, string email, string sdt)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.Tuoi = tuoi;
            this.Email = email;
            this.Sdt = sdt;
        }

        public KhachHang()
        {
        }
    }
}
