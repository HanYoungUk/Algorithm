using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             int count = int.Parse(Console.ReadLine());

            int result = 0;
            for(int i = 0; i < count; i++)
            {
                string str = Console.ReadLine();

                if (str.Equals("Never gonna give you up"))
                {
                    result++;
                }
                else if (str.Equals("Never gonna let you down"))
                {
                    result++;
                }
                else if (str.Equals("Never gonna run around and desert you"))
                {
                    result++;
                }
                else if (str.Equals("Never gonna make you cry"))
                {
                    result++;
                }
                else if (str.Equals("Never gonna say goodbye"))
                {
                    result++;
                }
                else if (str.Equals("Never gonna tell a lie and hurt you"))
                {
                    result++;
                }
                else if (str.Equals("Never gonna stop"))
                {
                    result++;
                }
            }

            if(count == result)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }

        }
    }
}
