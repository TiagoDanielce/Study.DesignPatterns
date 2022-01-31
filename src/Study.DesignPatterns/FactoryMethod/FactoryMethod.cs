using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.DesignPatterns
{
    public interface ICharacter
    {
        void Selected();
    }

    public class LiuKang : ICharacter
    {
        public void Selected()
        {
            Console.WriteLine("Liu Kang");
        }
    }

    public class SubZero : ICharacter
    {
        public void Selected()
        {
            Console.WriteLine("SubZero");
        }
    }

    public class Scorpion : ICharacter
    {
        public void Selected()
        {
            Console.WriteLine("Scorpion");
        }
    }

    public class FactoryMethod
    {
        public ICharacter SelectCharacter(string character)
        {
            switch (character)
            {
                case "Liu Kang":
                    return new LiuKang();
                case "Scorpion":
                    return new Scorpion();
                case "SubZero":
                    return new SubZero();
                default:
                    return default;
            }
        }
    }
}
