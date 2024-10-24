using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            if(x == 60 && y == 60 && z == 60){ Console.WriteLine("Equilateral"); }
            else if(x + y + z == 180 && x != y && y != z && z != x) { Console.WriteLine("Scalene"); }
            else if(x + y + z > 180 || x + y + z < 180) { Console.WriteLine("Error"); }
            else { Console.WriteLine("Isosceles"); }      
        }
    }
}