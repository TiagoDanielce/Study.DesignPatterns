using Study.DesignPatterns.AbstractFactory;
using Study.DesignPatterns.Builder;
using Study.DesignPatterns.Prototype;
using System;

namespace Study.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonTest();
            FactoryMethodTest();
            AbstractFactoryTest();
            BuilderTest();
            PrototypeTest();

            Console.ReadKey();
        }

        private static void BuilderTest()
        {
            var computer = new ComputerBuilder()
                .WithCpuManufacturer(ECpuManufacturer.AMD)
                .WithCpuModel("Ryzen 5 3600x")
                .WithMotherBoardCompatibility(EMotherBoardCompatibility.AMD)
                .WithMotherBoardModel("Gigabyte Aorus B450")
                .WithRamMemoryManufacturer(ERamMemoryManufacturer.Crucial)
                .WithRamMemorySize(32)
                .Build();

            Console.ReadKey();
        }

        private static void AbstractFactoryTest()
        {
            Person swedishPerson = ExecuteAbstractFactory.BuildPerson(EPersonType.Swedish);
            Person brazilianPerson = ExecuteAbstractFactory.BuildPerson(EPersonType.Brazilian);

            Console.ReadKey();
        }

        private static void PrototypeTest()
        {
            var customer = new Customer() { Name = "John", Email = "john@gmail.com", Document = "1234567890" };
            var customerCopy = (Customer)customer.Clone();

            Console.ReadKey();
        }

        private static void FactoryMethodTest()
        {
            var factory = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();
            Console.WriteLine("Choose you character");

            var selected = Console.ReadLine();

            var character = factory.SelectCharacter(selected);
            Console.WriteLine();
            Console.Write("You will play with ");
            character.Selected();

            Console.ReadKey();
        }

        private static void SingletonTest()
        {
            var playerOne = Singleton.GetInstance;
            playerOne.Message("Primeiro Jogador: A bola está comigo no meio do campo");

            var playerTwo = Singleton.GetInstance;
            playerTwo.Message("Segundo Jogador: recebeu a bola");
        }
    }
}
