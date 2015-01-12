using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void test1()
        {
            Geometry.Geometry geom = new Geometry.Geometry(190, 65, 244, 216, 307, 196);
            Assert.IsFalse(geom.CheckDot());
        }
        [Test]
        public void test2()
        {
            Geometry.Geometry geom = new Geometry.Geometry(84, 75, 327, 82, 92, 187);
            Assert.IsFalse(geom.CheckDot());
        }
    }
}