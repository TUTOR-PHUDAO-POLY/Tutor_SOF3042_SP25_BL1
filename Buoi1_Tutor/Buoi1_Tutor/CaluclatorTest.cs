using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Tutor
{
    [TestFixture]
    // day la class dung de viet unit test => NUnit/XUnit
    public class CaluclatorTest
    {
        private Caluclator caluclator;
        // Khoi tao cac gia tr ban dau truoc khi thuc thi cac test case
        [SetUp]
        public void Setup()
        {
            caluclator = new Caluclator();
        }
        // thuc thi test
        // viet cac function test
        // Cu phap viet testcase
        //[Test]
        //public void TestMau()
        //{
        //    // lam gi thi lam
        //}
        // Tinh tong 
        // so be cua kieu du lieu int,so lon nhat cua int 
        // phan vung 
        // case hop le trong khoang dieu kien: 3,2
        // ket qua thuc te & ket qua mong muon 
        // C1: Thuc thi rieng le tung ham => Test
        //[Test]
        //public void TinhTongHaiSoNguyenHopLeTrongKhoangDieuKien()
        //{
        //    var ketQuaThucTe = caluclator.TinhTong(3, 2);
        //    // ss voi ket qua mong muon
        //    // ArEqual => Mong muon, Thuc te
        //    //Assert.AreEqual(5, ketQuaThucTe);
        //    // Assert.That (thuc te, mong muon = Is.EqualTo, NotNull....)
        //    Assert.That(ketQuaThucTe, Is.EqualTo(5));
        //}

        //// ngoai khoang dieu kien => tren 
        //[Test]
        //public void TinhTongHaiSoNguyenTraRaIntMaxValue()
        //{
        //    int firstNumber = int.MaxValue - 1;
        //    int secondNumber = 1;
        //    var ketQuaThucTe = caluclator.TinhTong(firstNumber,secondNumber);
        //    Assert.That(ketQuaThucTe, Is.EqualTo(int.MaxValue));
        //}

        //// ngoai khoang dieu kien => duoi 
        //[Test]
        //public void TinhTongHaiSoNguyenTraRaIntMinValue()
        //{
        //    int firstNumber = int.MinValue + 1;
        //    int secondNumber = -1;
        //    var ketQuaThucTe = caluclator.TinhTong(firstNumber, secondNumber);
        //    Assert.That(ketQuaThucTe, Is.EqualTo(int.MinValue));
        //}

        //[Test]
        //public void TinhTongHaiSoNguyenTraRaSoKhongVaSoDuong()
        //{
        //    var ketQuaThucTe = caluclator.TinhTong(0,1);
        //    Assert.That(ketQuaThucTe, Is.EqualTo(1));
        //}

        //[Test]
        //public void TinhTongHaiSoNguyenTraRaSoKhongVaSoAm()
        //{
        //    var ketQuaThucTe = caluclator.TinhTong(0, -1);
        //    Assert.That(ketQuaThucTe, Is.EqualTo(-1));
        //}

        // Giai phong tai nguyen sau khi thuc thi testcase xong 

        // C2: Thuc thi tat ca cac testcase trong 1 ham cho 1 function

        [TestCase(3,2,5)]
        [TestCase(0, 1, 1)]
        [TestCase(int.MaxValue -1, 1, int.MaxValue)]
        public void TestFunctionTinhTongHaiSoNguyen(int a, int b, int expectedResult)
        {
            int ketQuaThucTe = caluclator.TinhTong(a, b);
            Assert.That(ketQuaThucTe, Is.EqualTo(expectedResult));
        }

        // Giai phong tai nguyen 
        [TearDown]
        public void TearDown()
        {
            caluclator = null;
        }
    }
}
