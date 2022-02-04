namespace Study.DesignPatterns.AbstractFactory
{

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
