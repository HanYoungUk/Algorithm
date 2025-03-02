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

            List<double> list = new List<double>();
            for(int i = 0; i < count; i++)
            {
                double dou = double.Parse(Console.ReadLine());

                list.Add(dou);
            }

            list.Sort();
            int seven = 0;
            foreach(double d in list)
            {
                string ss = string.Format("{0:F3}", d);
                sb.AppendLine(ss);
                seven++;
                if(seven == 7)
                {
                    break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
