using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPicker.Core
{
    public class Team
    {
        private List<Hero> heroes = new List<Hero>();

        public void AddHero(Hero hero)
        {
            if (this.heroes.Count < 5)
            {
                this.heroes.Add(hero);
            }
            else
            {
                throw new ApplicationException("Team can't contain more than 5 heroes");
            }
        }
    }
}
