using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             StringBuilder sb = new StringBuilder();
            HashSet<string> set = new HashSet<string>();
            int length = 0;
            for (int i = 0; i < 5; i++)
            {
                string num = Console.ReadLine();

                set.Add(num);

                if (length == set.Count)
                {
                    //Console.WriteLine(num);
                    set.Remove(num);
                }

                length = set.Count;
            }

            foreach (var i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}
