using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string name;
            while (!string.IsNullOrEmpty(name = Console.ReadLine()))
            {
                string result = "";
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] == 'i')
                    {
                        result += 'e';
                    }
                    else if (name[j] == 'e')
                    {
                        result += 'i';
                    }
                    else if (name[j] == 'E')
                    {
                        result += 'I';
                    }
                    else if (name[j] == 'I')
                    {
                        result += 'E';
                    }
                    else
                    {
                        result += name[j];
                    }
                }
                sb.AppendLine(result);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
