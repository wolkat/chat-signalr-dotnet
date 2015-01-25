using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ChatServerTest
{
    [TestFixture]
    public class KalkulatorTest
    {
        private IKalkulator calculator = new Kalkulator();
        [Test]
        public void AddTest() 
        {

            Assert.That(calculator.Add(5, 5), Is.EqualTo(10));
            Assert.That(calculator.Add(-10, 5), Is.EqualTo(-5));
        }

        [Test]
        public void SubtractTest()
        {

            Assert.That(calculator.Subtract(5, 5), Is.EqualTo(0));
            Assert.That(calculator.Subtract(10, 5), Is.EqualTo(5));
        }

        [Test]
        public void MultiplyTest()
        {
            Assert.That(calculator.Multiply(5, 0), Is.EqualTo(0));
            Assert.That(calculator.Multiply(10, 5), Is.EqualTo(50));
        }

        [SetUp]
        public void SetUp() 
        {
            calculator = new Kalkulator();
        }
    }
}
