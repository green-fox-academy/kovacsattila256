using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuboid cuboid = new Cuboid(2,2,4);

            Console.WriteLine(cuboid.GetSurface());
            Console.WriteLine(cuboid.GetVolume());

            Console.ReadLine();
        }
    }
}
