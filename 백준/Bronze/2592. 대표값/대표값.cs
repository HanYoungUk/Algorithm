using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
              // 평균과 최빈값
              List<int> list = new List<int>(); // 최빈값을 구할 변수
              HashSet<int> set = new HashSet<int>(); // 최빈값을 구할 변수(중복 없는 자료형)
              int sum = 0; // 합계를 구할 변수
              for (int i = 0; i < 10; i++)
              {
                int x = Int32.Parse(Console.ReadLine());
                sum += x;
                list.Add(x);
                set.Add(x);
              }
              Dictionary<int, int> dic = new Dictionary<int, int>();

              foreach(int x in set) // 딕셔너리에 담을 for문
              {
                int count = 0; // 몇개 인지 세어줄 변수
                for(int i = 0; i < list.Count; i++)
                {
                    if(x == list[i])
                    {
                        count++;
                    }
                }
                dic[x] = count;
              }

              int max = 0; // count가 가장 많은 값을 구할 변수
              int value = 0; // 최빈값을 담을 변수
              foreach(var x in dic)
              {
                if (max < x.Value)
              {
                max = x.Value;
                value = x.Key;
              }
            }
            Console.WriteLine(sum / 10); // 평균
            Console.WriteLine(value); // 최빈값
        }
    }
}