using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            char result = 'N';

            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 1)
                {
                    if (result == 'N')
                    {
                        result = 'E';
                    }
                    else if (result == 'E')
                    {
                        result = 'S';
                    }
                    else if (result == 'S')
                    {
                        result = 'W';
                    }
                    else
                    {
                        result = 'N';
                    }
                }
                else if (n == 2)
                {
                    if (result == 'N')
                    {
                        result = 'S';
                    }
                    else if (result == 'E')
                    {
                        result = 'W';
                    }
                    else if (result == 'S')
                    {
                        result = 'N';
                    }
                    else
                    {
                        result = 'E';
                    }
                }
                else
                {
                    if (result == 'N')
                    {
                        result = 'W';
                    }
                    else if (result == 'E')
                    {
                        result = 'N';
                    }
                    else if (result == 'S')
                    {
                        result = 'E';
                    }
                    else
                    {
                        result = 'S';
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
