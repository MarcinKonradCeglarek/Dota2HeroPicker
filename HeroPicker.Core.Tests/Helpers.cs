namespace HeroPicker.Core.Test
{
    public class Helpers
    {
        public static Hero CreateHero(string name)
        {
            return new Hero(name, Attribute.Strength, new Attributes(0, 0, 0), new Attributes(0, 0, 0), Side.Dire);
        }
    }
}