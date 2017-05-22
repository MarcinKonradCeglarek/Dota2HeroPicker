using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HeroPicker.Core
{
    public class Hero
    {
        public Hero(string name)
        {
            this.Name = name;
            this.BadAgainst = new List<Hero>();
            this.GoodAgainst = new List<Hero>();
            this.Friends = new List<Hero>();
        }

        public string Name { get; }

        public List<Hero> BadAgainst { get; }

        public List<Hero> GoodAgainst { get; }

        public List<Hero> Friends { get; }
    }
}
