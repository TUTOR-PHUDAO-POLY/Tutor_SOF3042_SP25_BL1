using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Tutor
{
    [TestFixture]
    public class SanPhamDienTuServiceTest
    {
        private SanPhamDienTuService _spservice;

        [SetUp]
        public void SetUp()
        {
            _spservice = new SanPhamDienTuService();
        }

        // case 1 => them thanh cong 1 san pham
        [Test]
        public void TestThemSanPhamVoiMotSanPhamSuccess()
        {
            SanPhamDienTu sp = new SanPhamDienTu("SP01", "San pham1", 10.5F, 3, 3, "Thuong 1");
            _spservice.ThemSanPham(sp);
            // kiem tra 2 y
            // size -> tang len 1 
            // kiem tra dau vao trong list la dung 
            var lists = _spservice.GetAll();
            Assert.That(lists.Count, Is.EqualTo(1)); // size 
            Assert.That(lists[0].MaSP, Is.EqualTo("SP01")); // gia tri 
            // ghi cac truong con lai
            Assert.That(lists[0].TenSP, Is.EqualTo("San pham1")); // gia tri 
        }
        // Case 2: Them 2 sp => success
        // Case 3: Them 2 sp co ten trung nhau => sucess
        // Case 4 : Fail -> check trong : ma trong 
        //""
        //"     "
        [TestCase("")]
        [TestCase("    ")]
        public void TestThemSanPhamFailKhiMaTrong(String maSP)
        {
            SanPhamDienTu sp = new SanPhamDienTu(maSP,"Ten 1",10.5F,2,4,"Thuong hieu 1");
            var ex = Assert.Throws<ArgumentException>(()=>_spservice.ThemSanPham(sp));
            Assert.That(ex.Message, Is.EqualTo("Khong duoc phep de trong"));
        }

        // case 5,6 : check trong ten, thuong hieu: Tuong tu case 4
        // gia am, so luong am, nam bao hanh am : Tuong tu nhu case 4,5,6
        [TestCase(0)]
        [TestCase(-3)]
        public void TestThemSanPhamFailKhiGiaAm(float gia)
        {
            SanPhamDienTu sp = new SanPhamDienTu("SP01", "Ten 1", gia, 2, 4, "Thuong hieu 1");
            var ex = Assert.Throws<ArgumentException>(() => _spservice.ThemSanPham(sp));
            Assert.That(ex.Message, Is.EqualTo("Gia khong duoc phep nho hon 0"));
        }

        // SS ca 1 doi tuong null: Does.Contain
        [Test]
        public void TestThemSanPhamFailKhiDoiTuongNull()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => _spservice.ThemSanPham(null));
            Assert.That(ex.Message, Does.Contain("San pham khong duoc null"));
        }

        [TearDown]
        public void TearDown()
        {
            _spservice = null;
        }
    }
}
