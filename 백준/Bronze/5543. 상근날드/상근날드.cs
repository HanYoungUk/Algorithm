using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int top, middle, bottom, cola, saida;
            
            top = int.Parse(Console.ReadLine());
            middle = int.Parse(Console.ReadLine());
            bottom = int.Parse(Console.ReadLine());
            cola = int.Parse(Console.ReadLine());
            saida = int.Parse(Console.ReadLine());

            List<int> hamburger = new List<int>();
            hamburger.Add(top);
            hamburger.Add(middle);
            hamburger.Add(bottom);

            List<int> drink = new List<int>();
            drink.Add(cola);
            drink.Add(saida);

            hamburger.Sort();
            drink.Sort();

            int result = hamburger[0] + drink[0] - 50;

            Console.WriteLine(result);
        }
    }
}
