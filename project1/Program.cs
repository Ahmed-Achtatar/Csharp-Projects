using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Character S = new(15);
            Console.WriteLine(S.Health);
        }
    }
}
