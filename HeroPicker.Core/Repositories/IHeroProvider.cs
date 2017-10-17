using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroPicker.Core.Repositories
{
    public interface IHeroProvider
    {
        IEnumerable<Hero> GetAllHeroes();

        Hero GetHero(string name);
    }
}
