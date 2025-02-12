using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Tutor
{
    public class SanPhamService
    {
        // viet cac ham them/sua/xoa
        private List<SanPham>listSanPham = new List<SanPham>();

        // ham get tat cac cac san pham dang co trong list
        public List<SanPham> GetAll()
        {
            return listSanPham;
        }

        // Add 
        public void AddSanPham(SanPham sp)
        {
            listSanPham.Add(sp);
        }
        // Sua, Xoa tuong tu
    }
}
