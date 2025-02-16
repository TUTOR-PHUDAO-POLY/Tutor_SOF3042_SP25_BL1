using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Tutor
{
    public class SanPhamDienTuService
    {
        private List<SanPhamDienTu> lists = new List<SanPhamDienTu>();

        public List<SanPhamDienTu> GetAll()
        {
            return lists;
        }

        public void ThemSanPham(SanPhamDienTu sp)
        {
            // check cai gi
            if(sp == null)
            {
                throw new ArgumentNullException("San pham khong duoc null");
            }
            // bat ca nhung case "      ": Co dau space => string.IsNullOrWhiteSpace()
            if (string.IsNullOrWhiteSpace(sp.MaSP) || string.IsNullOrWhiteSpace(sp.TenSP)
                || string.IsNullOrWhiteSpace(sp.ThuongHieu) )
            {
                throw new ArgumentException("Khong duoc phep de trong");
            }
            // gia | nam bao hanh
            if(sp.Gia <= 0)
            {
                throw new ArgumentException("Gia khong duoc phep nho hon 0");
            }
            if (sp.BaoHanh <= 0)
            {
                throw new ArgumentException("Nam Bao hanh khong duoc phep nho hon 0");
            }
            if (sp.SoLuong <= 0)
            {
                throw new ArgumentException("So luong khong duoc phep nho hon 0");
            }
            // Oke => Thuc hien ham
            lists.Add(sp);
        }
    }
}
