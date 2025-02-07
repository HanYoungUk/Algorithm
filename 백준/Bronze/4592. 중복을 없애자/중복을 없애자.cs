using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while(true)
            {
                string str = Console.ReadLine();
                if (str.Equals("0"))
                {
                    break;
                }

                string[] arr = str.Split(" ");
                string x = "";
                List<string> list = new List<string>();

                for (int i = 1; i < arr.Length; i++)
                {
                    if (x.Equals(arr[i]))
                    {
                        continue;
                    }

                    x = arr[i];
                    list.Add(x);
                }

                foreach(var i in list)
                {
                    sb.Append(i + " ");
                }

                sb.AppendLine("$");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
