using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            List<int> science = new List<int>() { a, b, c, d};
            science.Sort();

            int sum = 0;

            for(int i = 1; i < science.Count; i++)
            {
                sum += science[i];
            }

            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());

            if (e > f)
            {
                sum += e;

                Console.WriteLine(sum);
            }
            else
            {
                sum += f;
                Console.WriteLine(sum);
            }
        }
    }
}
