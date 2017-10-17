using System;
using System.Linq;
using NUnit.Framework;

namespace HeroPicker.Core.Test
{
    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void Hero_AddBadAgainst_ReturnsHeroOnBadAgainstList()
        {
            var hero = Helpers.CreateHero("A");
            var sut = Helpers.CreateHero("SUT");

            Assert.DoesNotThrow(() => sut.AddBadAgainst(hero));
            Assert.IsTrue(sut.BadAgainst.Contains(hero));
        }

        [Test]
        public void Hero_AddBadAgainstTwice_ThrowsException()
        {
            var hero = Helpers.CreateHero("A");
            var sut = Helpers.CreateHero("SUT");

            Assert.DoesNotThrow(() => sut.AddBadAgainst(hero));
            var exception = Assert.Throws<ApplicationException>(() => sut.AddBadAgainst(hero));
            Assert.AreEqual("Hero A is already on BadAgainst list", exception.Message);
        }

        [Test]
        public void Hero_AddFriend_ReturnsHeroOnFriendList()
        {
            var hero = Helpers.CreateHero("A");
            var sut = Helpers.CreateHero("SUT");

            Assert.DoesNotThrow(() => sut.AddFriend(hero));
            Assert.IsTrue(sut.Friends.Contains(hero));
        }

        [Test]
        public void Hero_AddFriendTwice_ThrowsException()
        {
            var hero = Helpers.CreateHero("A");
            var sut = Helpers.CreateHero("SUT");

            Assert.DoesNotThrow(() => sut.AddFriend(hero));
            var exception = Assert.Throws<ApplicationException>(() => sut.AddFriend(hero));
            Assert.AreEqual("Hero A is already on Friends list", exception.Message);
        }

        [Test]
        public void Hero_AddGoodAgainst_ReturnsHeroOnGoodAgainstList()
        {
            var hero = Helpers.CreateHero("A");
            var sut = Helpers.CreateHero("SUT");

            Assert.DoesNotThrow(() => sut.AddGoodAgainst(hero));
            Assert.IsTrue(sut.GoodAgainst.Contains(hero));
        }

        [Test]
        public void Hero_AddGoodAgainstTwice_ThrowsException()
        {
            var hero = Helpers.CreateHero("A");
            var sut = Helpers.CreateHero("SUT");

            Assert.DoesNotThrow(() => sut.AddGoodAgainst(hero));
            var exception = Assert.Throws<ApplicationException>(() => sut.AddGoodAgainst(hero));
            Assert.AreEqual("Hero A is already on GoodAgainst list", exception.Message);
        }

        [Test]
        public void Hero_TestEqualityOfDiffrentHeroes_ReturnsFalse()
        {
            var a = Helpers.CreateHero("A");
            var b = Helpers.CreateHero("B");

            Assert.AreNotEqual(a, b);
        }

        [Test]
        public void Hero_TestEqualityOfSameHero_ReturnsTrue()
        {
            var a = Helpers.CreateHero("Zeus");
            var b = Helpers.CreateHero("Zeus");

            Assert.AreEqual(a, b);
        }


    }
}