using System;
namespace CSharpBasics
{
    public class CSharpMethods
    {
        public string Name { get; set; }

        public string GetName()
        {
            return Name = Console.ReadLine();
        }

        public void PrintGreeting()
        {
            Console.WriteLine("Hi, " + Name);
        }

    }
}
