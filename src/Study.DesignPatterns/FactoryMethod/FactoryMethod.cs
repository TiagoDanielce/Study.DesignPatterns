namespace Study.DesignPatterns
{
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
