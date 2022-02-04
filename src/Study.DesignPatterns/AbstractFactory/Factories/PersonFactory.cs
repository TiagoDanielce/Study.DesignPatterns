namespace Study.DesignPatterns.AbstractFactory
{
    public abstract class PersonFactory
    {
        public abstract Hair CreateHair();
        public abstract Eyes CreateEyes();
    }
}
