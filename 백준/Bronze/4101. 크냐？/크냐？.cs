using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> list = new List<string>(); // 결과를 담을 list 선언
             while (true)
             {
                 string str = Console.ReadLine();
                 if (str.Equals("0 0"))
                 {
                     break;
                 }
                 string[] arr = str.Split(" ");

                 long a = long.Parse(arr[0]);
                 long b = long.Parse(arr[1]);

                 if(a > b)
                 {
                     list.Add("Yes");
                 }
                 else
                 {
                     list.Add("No");
                 }

             }

             foreach(var i in list)
             {
                 Console.WriteLine(i);
             }
        }
    }
}