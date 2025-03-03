using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string full = Console.ReadLine();
            string[] fullarr = full.Split(" ");

            string recently = Console.ReadLine();
            string[] recenarr = recently.Split(" ");

            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < fullarr.Length; i++)
            {
                dic.Add(fullarr[i], 1);
            }

            foreach (var i in recenarr)
            {
                if (dic.ContainsKey(i))
                {
                    dic[i]++;
                }
            }
            string result = "";
            foreach (var i in dic)
            {
                if (i.Value == 1)
                {
                    result = i.Key;
                }
            }

            Console.WriteLine(result);             
        }
    }
}
