using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2_Tutor
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // thuc thi viet test 
        [Test]
        public void TestTinhThuongHaiSoNguyenThanhCong()
        {
            var ketQuaThucTe = _calculator.TinhThuongHaiSoNguyen(5, 4);
            Assert.That(ketQuaThucTe, Is.EqualTo(1.25));
        }

        [TestCase(5, 4, 1.25)]
        [TestCase(3, 2, 1.5)]
        public void TestTinhThuongHaiSoNguyenThanhCong1(int a, int b, double ketQuaMongMuon)
        {
            var ketQuaThucTe = _calculator.TinhThuongHaiSoNguyen(a,b);
            Assert.That(ketQuaThucTe, Is.EqualTo(ketQuaMongMuon));
        }

        // Co 2 cach de xu ly ngoai le
        // C1: Assert.Throw 
        // C2: try...catch 
        [Test]
        public void TestTinhThuongHaiSoNguyenNgoaiLeChiaCho0()
        {
            var ex = Assert.Throws<DivideByZeroException>(
                () => _calculator.TinhThuongHaiSoNguyen(5, 0));
            Assert.That(ex.Message, Is.EqualTo("Attempted to divide by zero."));
        }

        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }
    }
}
