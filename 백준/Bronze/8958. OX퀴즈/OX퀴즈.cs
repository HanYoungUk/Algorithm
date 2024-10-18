using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(); // 결과를 출력할 리스트
            for(int i = 0; i < num; i++)
            {
                string x = Console.ReadLine();
                int count = 0; // O일 경우 숫자 증가
                int sum = 0;
                for (int j = 0; j < x.Length; j++)
                {
                    if(x[j] == 'O')
                    {
                        count++;
                        sum += count;
                    }
                    else // X일경우
                    {
                        count = 0;
                    }
                }
                list.Add(sum);
            }
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}