using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3_Tutor
{
    [TestFixture]
    public class CaluculatorTest
    {
        private Caluculator _caluculator;
        [SetUp]
        public void Setup()
        {
            _caluculator = new Caluculator();
        }
        // thuc thi test 

        [TestCase(0, 0)] // bien duoi
        [TestCase(1, 1)] // bien nho nhat
        [TestCase(9, 3)] // test so chinh phuong
        [TestCase(13, 3.60555)] // test so khong chinh phuong
        [TestCase(100, 10)] // test gia tri lon
        [TestCase(int.MaxValue, 46340.95)] // test gia tri lon - int.MaxValue
        public void TestFunctionTinhCanBacHaiCuaSoNguyenSuccess
            (int number, double expectedResult)
        {
            double actualResult = _caluculator.TinhCanBacHai(number);
            Assert.That(expectedResult, Is.EqualTo(actualResult).Within(0.0001));
        }

        // Viet case Fail
        // C1: Su dung Assert.Throws
        // C2: Su dung try...catch 
        [Test]
        // C1: Su dung Assert.Throws
        public void TestFunctionTinhCanBacHaiCuaSoNguyenFail()
        {
            Assert.Throws
                (typeof(ArgumentOutOfRangeException), 
                () => _caluculator.TinhCanBacHai(-3));
        }
        // C2: try...catch => Assert.Fail
        public void TestFunctionTinhCanBacHaiCuaSoNguyenFail2()
        {
            try
            {
                // nghi ngo co loi
                _caluculator.TinhCanBacHai(-3);
                Assert.Fail("Hi vong co expections");
            }catch (ArgumentOutOfRangeException e) {
                // ss loai type cua expection khi chuong trinh xay ra ngoai le
                // ths => type cua kq mong muon
                Assert.That(typeof(ArgumentOutOfRangeException), Is.EqualTo(e.GetType()));
            }
        }
        [TearDown]
        public void Teardown()
        {
            _caluculator = null;
        }
    }
}
