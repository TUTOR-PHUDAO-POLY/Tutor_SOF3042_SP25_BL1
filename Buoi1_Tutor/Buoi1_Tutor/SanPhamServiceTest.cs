using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Tutor
{
    [TestFixture]
    public class SanPhamServiceTest
    {
        private SanPhamService service;

        [SetUp]
        public void Setup()
        {
            service = new SanPhamService();
        }

        // test
        [Test]
        public void TestAddSanPhamSuccess()
        {
            // Goi ham add san pham
            SanPham sp = new SanPham("SP01", "San pham1", 10, 100, "Sach thieu nhi");
            service.AddSanPham(sp);
            // Kiem tra test (2 y)
            // Kiem tra: size cua mang co duoc tang hay khong
            var lists = service.GetAll();
            Assert.That(lists.Count, Is.EqualTo(1)); // kiem tra xem size co tang khong
            // kiem tra: du lieu vua moi them co dung hay khong 
            Assert.That(lists[0].MaSP, Is.EqualTo("SP01"));
            Assert.That(lists[0].TenSP, Is.EqualTo("San pham1"));
        }

        [Test]
        public void TestAddHaiSanPhamSuccess()
        {
            // Goi ham add san pham
            SanPham sp = new SanPham("SP01", "San pham1", 10, 100, "Sach thieu nhi");
            SanPham sp1 = new SanPham("SP02", "San pham1", 10, 100, "Sach thieu nhi");
            service.AddSanPham(sp);
            service.AddSanPham(sp1);
            // Kiem tra test (2 y)
            var lists = service.GetAll();
            Assert.That(lists.Count, Is.EqualTo(2)); 
        }
        // viet cac testcase khi them du lieu giong ve ma, giong ve tiltle

        [TearDown]
        public void Teardown()
        {
            service = null;
        }
    }
}
