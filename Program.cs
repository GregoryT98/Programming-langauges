namespace CharacterCreation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Character Creation Program!");
            Console.WriteLine("Please enter your character's name:");
            CharacterClass character1 = new CharacterClass();
            character1.partyName = Console.ReadLine();
            Console.WriteLine("Please enter your character's class:");
            character1.partyClass = Console.ReadLine();

        }
    }
}




