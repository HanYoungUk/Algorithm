using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<int> list = new List<int>(); // 만들 수 있는 케이크양을 담을 수 있는 리스트

            for(int i = 0; i < num; i++)
            {
                string[] arr = Console.ReadLine().Split(" ");

                int required = int.Parse(arr[0]); // 필요한 재료의 양
                int save = int.Parse(arr[1]); // 가지고 있는 재료의 양

                int make = save / required; // 만들 수 있는 케이크 양

                list.Add(make);
            }

            list.Sort();

            Console.WriteLine(list[0]);
        }
    }
}
