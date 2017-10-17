using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HeroPicker.Core
{
    public class Hero : IEquatable<Hero>
    {
        private readonly List<Hero> _badAgainst;
        private readonly List<Hero> _friends;
        private readonly List<Hero> _goodAgainst;

        public Hero(string name, Attribute primaryAttribute, Attributes baseAttributes, Attributes levelIncrease, Side side)
        {
            this.Side = side;
            this.Name = name;
            this.PrimaryAttribute = primaryAttribute;
            this.BaseAttributes = baseAttributes;
            this.LevelIncrease = levelIncrease;

            this._badAgainst = new List<Hero>();
            this._goodAgainst = new List<Hero>();
            this._friends = new List<Hero>();
        }

        public Side Side { get; }

        public string Name { get; }

        public Attribute PrimaryAttribute { get; }

        public Attributes BaseAttributes { get; }

        public Attributes LevelIncrease { get; }

        public IReadOnlyCollection<Hero> BadAgainst => new ReadOnlyCollection<Hero>(this._badAgainst);

        public IReadOnlyCollection<Hero> GoodAgainst => new ReadOnlyCollection<Hero>(this._goodAgainst);

        public IReadOnlyCollection<Hero> Friends => new ReadOnlyCollection<Hero>(this._friends);

        public bool Equals(Hero other)
        {
            return other != null && this.Name == other.Name;
        }

        public void AddBadAgainst(Hero hero)
        {
            if (this._badAgainst.Contains(hero))
            {
                throw new ApplicationException($"Hero {hero.Name} is already on {nameof(this.BadAgainst)} list");
            }

            this._badAgainst.Add(hero);
        }

        public void AddGoodAgainst(Hero hero)
        {
            if (this._goodAgainst.Contains(hero))
            {
                throw new ApplicationException($"Hero {hero.Name} is already on {nameof(this.GoodAgainst)} list");
            }

            this._goodAgainst.Add(hero);
        }

        public void AddFriend(Hero hero)
        {
            if (this._friends.Contains(hero))
            {
                throw new ApplicationException($"Hero {hero.Name} is already on {nameof(this.Friends)} list");
            }

            this._friends.Add(hero);
        }
    }
}