using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = int.Parse(Console.ReadLine());

            List<int> scoreList = new List<int>();
            List<int> codeLengthList = new List<int>();

            for (int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();
                string[] arr = str.Split(" ");

                scoreList.Add(int.Parse(arr[0]));
                codeLengthList.Add(int.Parse(arr[1]));

            }

            scoreList.Sort();
            codeLengthList.Sort();

            long num = scoreList[scoreList.Count - 1] * codeLengthList[0];

            long result = (num % 7) + 1;

            Console.WriteLine(result);
        }
    }
}
