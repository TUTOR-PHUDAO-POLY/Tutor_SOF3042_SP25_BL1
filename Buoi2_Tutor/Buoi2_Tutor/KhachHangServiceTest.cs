using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Tutor
{
    [TestFixture]
    public class KhachHangServiceTest
    {
        private KhachHangService _service;

        [SetUp]
        public void Setup()
        {
            _service = new KhachHangService();
        }
        // thuc thi test 
        [Test]
        public void TestAddKhachHangSuccess()
        {
            KhachHang kh = new KhachHang("KH01", "KHach hang 1", 10, "khachhang@gmai.com", "01234546");
            _service.AddKhachHang(kh);
            // ss 
            var list = _service.GetKhachHangs();
            Assert.That(list.Count, Is.EqualTo(1));
            Assert.That(list[0].Ma, Is.EqualTo("KH01"));
        }

        [Test]
        public void TestAddKhachHangKhiMaEmpty()
        {
            KhachHang kh = new KhachHang("", "KHach hang 1", 10, "khachhang@gmai.com", "01234546");
            Assert.IsFalse(_service.AddKhachHang(kh));
        }
        
        // false 
        // test false ma 
        [Test]
        public void TestAddKhachHangFailMa()
        {
            KhachHang kh = new KhachHang("", "KHach hang 1", 10, "khachhang@gmai.com", "01234546");
            Assert.Throws<ArgumentException>(() => _service.AddKhachHangC2(kh));
        }

        [TearDown]
        public void TearDown() { _service = null; }

    }
}
