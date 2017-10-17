using System;
using NUnit.Framework;

namespace HeroPicker.Core.Test
{
    [TestFixture]
    public class TeamTests
    {
        [Test]
        public void Team_AddingSameHeroTwice_ThrowsException()
        {
            var sut = new Team(Side.Dire);
            var hero = Helpers.CreateHero("Hero");

            Assert.DoesNotThrow(() => sut.AddHero(hero));
            var exception = Assert.Throws<ApplicationException>(() => sut.AddHero(hero));
            Assert.AreEqual("This team already contains Hero", exception.Message);
        }

        [Test]
        public void Team_Adds6Heroes_ExceptionThrown()
        {
            var sut = new Team(Side.Dire);
            Hero hero;

            for (var i = 0; i < 5; i++)
            {
                hero = Helpers.CreateHero("Hero" + i);
                Assert.DoesNotThrow(() => sut.AddHero(hero));
            }

            hero = Helpers.CreateHero("6thHero");
            var exception = Assert.Throws<ApplicationException>(() => sut.AddHero(hero));
            Assert.AreEqual("Team can't contain more than 5 heroes", exception.Message);
        }

        [Test]
        public void Team_AddsHero_NoExceptionThrown()
        {
            var sut = new Team(Side.Dire);
            var hero = Helpers.CreateHero("Hero1");

            Assert.DoesNotThrow(() => sut.AddHero(hero));
        }
    }
}