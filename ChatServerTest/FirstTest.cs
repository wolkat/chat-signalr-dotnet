using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ChatServerTest
{
    [TestFixture]
    public class FirstTestSuite
    {
        [NUnit.Framework.Test]
        public void FirstTest()
        {
            var s = MetodaPomocnicza();
            Assert.AreEqual("test",s);
        }

        //[NUnit.Framework.Test]
        [Test]
        public void SecondTest()
        {
            var s = MetodaPomocnicza();
        }

        public string MetodaPomocnicza()
        {
            return "test";
        }
    }
}
