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
            Dictionary<string, string> dic = new Dictionary<string, string>();

            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                if (dic.ContainsKey(arr[0]))
                {
                    dic.Remove(arr[0]);
                }
                else
                {
                    dic.Add(arr[0], arr[1]);
                }
            }
            List<string> list = new List<string>();
            foreach(var i in dic)
            {
                list.Add(i.Key);
            }
            list.Sort();
            list.Reverse();

            foreach(var i in list)
            {
                sb.AppendLine(i);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
