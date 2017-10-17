using System;
using System.Collections.Generic;

namespace HeroPicker.Core
{
    public class Team
    {
        private readonly List<Hero> _heroes = new List<Hero>();

        private const int MaxTeamMembers = 5;

        public Team(Side side)
        {
            this.Side = side;
        }

        private Side Side { get; }

        public void AddHero(Hero hero)
        {
            if (this._heroes.Count < MaxTeamMembers)
            {
                if (this._heroes.Contains(hero))
                {
                    throw new ApplicationException($"This team already contains {hero.Name}");
                }

                this._heroes.Add(hero);
            }
            else
            {
                throw new ApplicationException($"Team can't contain more than {MaxTeamMembers} heroes");
            }
        }
    }
}