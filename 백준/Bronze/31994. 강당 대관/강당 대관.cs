using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for(int i = 0; i < 7; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                dic.Add(arr[0], int.Parse(arr[1]));
            }

            int max = 0;
            string result = "";
            foreach(var i in dic)
            {
                if(i.Value > max)
                {
                    result = i.Key;
                    max = i.Value;
                }
            }

            Console.WriteLine(result);
        }
    }
}
