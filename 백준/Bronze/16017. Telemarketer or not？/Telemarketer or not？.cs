using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string str = "";
            while (a++ < 4)
            {
                str += Console.ReadLine();
            }
            string result = "";
            if (str[0] == '8' || str[0] == '9')
            {
                if (str[3] == '8' || str[3] == '9')
                {
                    if (str[1] == str[2])
                    {
                        result = "ignore";
                    }
                    else
                    {
                        result = "answer";
                    }
                }
                else
                {
                    result = "answer";
                }
            }
            else
            {
                result = "answer";
            }

            Console.WriteLine(result);
        }
    }
}
