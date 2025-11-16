using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int menucount = int.Parse(Console.ReadLine());
            List<int> menu = new List<int>();

            for (int i = 0; i < menucount; i++)
            {
                menu.Add(int.Parse(Console.ReadLine()));
            }

            int human = int.Parse(Console.ReadLine());

            long result = 0;
            for (int i = 0; i < human; i++)
            {
                int choice = int.Parse(Console.ReadLine());

                result += menu[choice - 1];
            }
            Console.WriteLine(result);
        }
    }
}
