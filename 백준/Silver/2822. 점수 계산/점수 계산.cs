using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                int num = int.Parse(Console.ReadLine());

                list.Add(num);
                dic.Add(i + 1, num);
            }

            list.Sort();

            List<int> list2 = new List<int>();
            for(int i = 3; i < list.Count; i++)
            {
                sum += list[i];
                foreach (var j in dic)
                {
                    if (j.Value == list[i])
                    {
                        list2.Add(j.Key);
                    }
                }
            }
            list2.Sort();
            Console.WriteLine(sum);

            foreach (var i in list2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
