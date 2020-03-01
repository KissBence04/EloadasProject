using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject.Tests
{
    [TestFixture]
    class EloadasTeszt
    {
        Eloadas e;
        [SetUp]
        public void SokFerohelyesEloadas()
        {
            e = new Eloadas(6, 40);
        }

        [TestCase]
        public void UjEloadasMindenHelyreUres()
        {
            Assert.AreEqual(6, e.SzabadHelyek, "Üres előadás nem üres minden hely");
        }

        [TestCase]
        public void EloadasTeliE()
        {
            for (int i = 0; i < 32; i++)
            {
                e.Lefoglal();
            }
            Assert.IsTrue(e.Teli(), "Teli előadás még sincs tele");
        }
    }
}
