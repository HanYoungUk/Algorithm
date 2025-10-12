using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            string str = Console.ReadLine();

            string[] arr = str.Split(" ");

            int N = int.Parse(arr[0]); // 걸그룹의 수
            int M = int.Parse(arr[1]); // 맞혀야할 수

            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>(); // 그룹에서 멤버 찾을 경우
            Dictionary<string, string> dic2 = new Dictionary<string, string>(); // 멤버에서 그룹 찾을 경우

            for (int i = 0; i < N; i++)
            {
                string girlName = Console.ReadLine();

                int count = int.Parse(Console.ReadLine());

                dic[girlName] = new List<string>();

                for (int j = 0; j < count; j++)
                {
                    string member = Console.ReadLine();
                    dic[girlName].Add(member);
                    dic2[member] = girlName;
                }
                dic[girlName].Sort();
            }

            for (int i = 0; i < M; i++) // 이제 문제를 받아야함.
            {
                string name = Console.ReadLine(); // 이름을 입력받음

                int x = int.Parse(Console.ReadLine()); // 0 == 그룹, 1 == 멤버

                if (x == 0) // 그룹에서 찾기
                {
                    foreach (var a in dic[name])
                    {
                        sb.AppendLine(a);
                    }
                }
                else
                {
                    sb.AppendLine(dic2[name]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
