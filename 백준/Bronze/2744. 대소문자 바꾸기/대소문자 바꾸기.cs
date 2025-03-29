using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             string str = Console.ReadLine();
             string result = "";

             for(int i = 0; i < str.Length; i++)
             {
                 if (str[i] >= 65 && str[i] <= 90)
                 {
                     result += (char)(str[i] + 32);
                 }
                 else
                 {
                     result += (char)(str[i] - 32);
                 }
             }
 
             Console.WriteLine(result);
        }
    }
}
