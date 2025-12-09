using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();

            int num = 1;
            for (char i = 'a'; i <= 'z'; i++)
            {
                dic.Add(i, num++);
            }

            int nameCount = int.Parse(Console.ReadLine());
            string name = Console.ReadLine().ToLower();

            int sum = 0;

            for (int i = 0; i < nameCount; i++)
            {
                sum += dic[name[i]];
            }

            Console.WriteLine(sum);
        }
    }
}
