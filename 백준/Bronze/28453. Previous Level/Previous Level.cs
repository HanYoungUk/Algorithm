using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(int.Parse(arr[i]));
            }

            foreach (var i in list)
            {
                if (i < 250)
                {
                    sb.Append("4 ");
                }
                else if (i >= 250 && i <= 274)
                {
                    sb.Append("3 ");
                }
                else if (i >= 275 && i <= 299)
                {
                    sb.Append("2 ");
                }
                else if (i >= 300)
                {
                    sb.Append("1 ");
                }
            }

            Console.WriteLine(sb.ToString()); 
        }
    }
}
