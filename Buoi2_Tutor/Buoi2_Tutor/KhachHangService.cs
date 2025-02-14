using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Tutor
{
    public class KhachHangService
    {
        private List<KhachHang> _list = new List<KhachHang>();

        public List<KhachHang> GetKhachHangs() { return _list; }

        public bool AddKhachHang(KhachHang kh)
        {
            if (kh.Ma == "" || kh.Ma == null || kh.Ten == "")
            {
                return false;
            }
            // check cac truong khac 
            _list.Add(kh);
            return true;
        }

        public void AddKhachHangC2(KhachHang kh)
        {
            if(kh.Ma == "" || kh.Ten == "")
            {
                throw new ArgumentException("khong duoc de trong");
            }
            _list.Add(kh);
        }
    }
}
