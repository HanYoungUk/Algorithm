using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int color = int.Parse(Console.ReadLine());

            if (color >= 620 && 780 >= color)
            {
                Console.WriteLine("Red");
            }
            else if(color >= 590 && color < 620)
            {
                Console.WriteLine("Orange");
            }
            else if(color >= 570 && color < 590)
            {
                Console.WriteLine("Yellow");
            }
            else if(color >= 495 && color < 570)
            {
                Console.WriteLine("Green");
            }
            else if (color >= 450 && color < 495)
            {
                Console.WriteLine("Blue");
            }
            else if (color >= 425 && color < 450)
            {
                Console.WriteLine("Indigo");
            }
            else
            {
                Console.WriteLine("Violet");
            }        
        }
    }
}
