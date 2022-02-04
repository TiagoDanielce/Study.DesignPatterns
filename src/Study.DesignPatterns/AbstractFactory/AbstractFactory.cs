namespace Study.DesignPatterns.AbstractFactory
{
    public class Person
    {
        public Hair Hair { get; set; }
        public Eyes Eyes { get; set; }
    }

    public class Hair { }

    public class ShortHair : Hair { }

    public class LongHair : Hair { }

    public class Eyes { }

    public class BlueEyes : Eyes { }

    public class BrownEyes : Eyes { }

    public abstract class PersonFactory
    {
        public abstract Hair CreateHair();
        public abstract Eyes CreateEyes();
    }

    public class SwedishPersonFactory : PersonFactory
    {
        public override Eyes CreateEyes() => new BlueEyes();

        public override Hair CreateHair() => new LongHair();
    }

    public class BrazilianPersonFactory : PersonFactory
    {
        public override Eyes CreateEyes() => new BrownEyes();

        public override Hair CreateHair() => new ShortHair();
    }

    public enum EPersonType
    {
        Swedish,
        Brazilian
    }

    public static class ExecuteAbstractFactory
    {
        public static Person BuildPerson(EPersonType personType)
        {
            var factory = ChooseFactory(personType);

            return new Person { Eyes = factory.CreateEyes(), Hair = factory.CreateHair() };
        }

        private static PersonFactory ChooseFactory(EPersonType personType) => personType switch
        {
            EPersonType.Swedish => new SwedishPersonFactory(),
            EPersonType.Brazilian => new BrazilianPersonFactory(),
            _ => default
        };
    }
}
