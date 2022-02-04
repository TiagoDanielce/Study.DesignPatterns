namespace Study.DesignPatterns.AbstractFactory
{
    public class BrazilianPersonFactory : PersonFactory
    {
        public override Eyes CreateEyes() => new BrownEyes();

        public override Hair CreateHair() => new ShortHair();
    }
}
