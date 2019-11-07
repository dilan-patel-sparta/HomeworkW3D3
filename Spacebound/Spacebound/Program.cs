using System;
using System.IO;
using System.Runtime.Serialization;

namespace Spacebound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SPACEBOUND");
            Game spacebound = new Game();
            spacebound.GameLoop();
        }

    }   
}
