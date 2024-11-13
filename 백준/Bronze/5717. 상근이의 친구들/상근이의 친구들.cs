using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
              List<int> list = new List<int>(); // 결과를 담을 list 선언

             while (true) 
             {
                 string[] arr = Console.ReadLine().Split(" ");

                 if (arr[0].Equals("0") && arr[1].Equals("0"))
                 {
                     break;
                 }

                 int boy = int.Parse(arr[0]);
                 int girl = int.Parse(arr[1]);

                 list.Add(boy + girl);    
             }    

             foreach (int i in list)
             {
                 Console.WriteLine(i);
             }
        }
    }
}