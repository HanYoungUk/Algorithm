using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             string human = Console.ReadLine();
             string doctor = Console.ReadLine();

             if(human.Length >= doctor.Length)
             {
                 Console.WriteLine("go");
             }
             else
             {
                 Console.WriteLine("no");
             }     
        }
    }
}