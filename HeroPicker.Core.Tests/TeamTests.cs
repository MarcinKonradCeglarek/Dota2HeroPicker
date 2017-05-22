using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HeroPicker.Core.Test
{
    [TestFixture]
    public class TeamTests
    {
        [Test]
        public void Team_AddsHero_NoExceptionThrown()
        {
            var sut = new Team();
            var hero = new Hero("Hero1");

            Assert.DoesNotThrow(() => sut.AddHero(hero));
        }

        [Test]
        public void Team_Adds6Heroes_ExceptionThrown()
        {
            var sut = new Team();
            Hero hero;

            for (var i = 0; i < 5; i++)
            {
                hero = new Hero("Hero" + i);
                Assert.DoesNotThrow(() => sut.AddHero(hero));
            }
            
            hero = new Hero("6thHero");
            Assert.Throws<ApplicationException>(() => sut.AddHero(hero));
        }

        [Test]
        public void Team_AddingSameHeroTwice_ThrowsException()
        {
            var sut = new Team();
            var hero = new Hero("Hero");

            Assert.DoesNotThrow(() => sut.AddHero(hero));
            Assert.Throws<ApplicationException>(() => sut.AddHero(hero));
        }
    }
}
