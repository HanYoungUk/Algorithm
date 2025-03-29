using System;
using System.ComponentModel;
using System.Numerics;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1; // 순위용 변수
            StringBuilder sb = new StringBuilder();
            int count = int.Parse(Console.ReadLine()); // 몇번 돌릴지
            List<(int weight, int height)> list = new List<(int weight, int height)>(); 

            for (int i = 0; i < count; i++)
            {
                string s = Console.ReadLine(); // 몸무게랑 키를 받을 변수
                string[] arr = s.Split(" ");
                int weight = int.Parse(arr[0]);
                int height = int.Parse(arr[1]);
                list.Add((weight, height));
            }

            // 키랑 몸무게 둘다가 자기보다 높은사람이 있으면 덩치쟁이다.
            foreach (var i in list)
            {
                int rank = 1;

                foreach (var j in list)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    if(i.weight < j.weight && i.height < j.height)
                    {
                        rank++;
                    }
                }
                sb.Append(rank + " ");
                rank = 1;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}