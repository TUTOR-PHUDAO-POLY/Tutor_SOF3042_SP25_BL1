using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Tutor
{
    public class SanPham
    {
        // maSP - String, tenSP - String, gia - float, soLuong - int, danhMuc - String.
        private String maSP;
        private String tenSP;
        private float gia;
        private int soLuong;
        private String danhMuc;

        public SanPham()
        {
        }

        public SanPham(string maSP, string tenSP, float gia, int soLuong, string danhMuc)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.Gia = gia;
            this.SoLuong = soLuong;
            this.DanhMuc = danhMuc;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public float Gia { get => gia; set => gia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
    }
}
