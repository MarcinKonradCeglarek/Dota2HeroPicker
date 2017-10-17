using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HeroPicker.Core
{
    public class Attributes : ReadOnlyDictionary<Attribute, float>
    {
        public Attributes(float strength, float agility, float inteligence)
            : base(
                new Dictionary<Attribute, float>
                {
                    {Attribute.Strength, strength},
                    {Attribute.Agility, agility},
                    {Attribute.Inteligence, inteligence}
                })
        {
        }
    }
}