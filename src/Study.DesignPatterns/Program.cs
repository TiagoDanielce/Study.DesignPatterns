using System;

namespace Study.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var playerOne = Singleton.GetInstance;
            playerOne.Message("Primeiro Jogador: A bola está comigo no meio do campo");

            var playerTwo = Singleton.GetInstance;
            playerTwo.Message("Segundo Jogador: recebeu a bola");

            Console.ReadKey();
        }
    }
}
