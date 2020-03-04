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

        [TestCase]
        public void UjEloadasNincsTeli()
        {
            Assert.IsFalse(e.Teli(), "Új előadás teli van");
        }

        [TestCase]
        public void TeliEloadasHelyfoglalas()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    e.Lefoglal();
                }  
            }
            e.Lefoglal();
            Assert.IsTrue(e.Teli(), "Még sincs tele");
        }

        [TestCase]
        public void RepuloFerohelyNemLehetNegativ()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                new Eloadas(-2,-5);
            }
            );
        }

        
    }
}
