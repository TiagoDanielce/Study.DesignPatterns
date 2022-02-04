namespace Study.DesignPatterns.AbstractFactory
{
    public class SwedishPersonFactory : PersonFactory
    {
        public override Eyes CreateEyes() => new BlueEyes();

        public override Hair CreateHair() => new LongHair();
    }
}
