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
    }
}
