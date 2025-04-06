using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>(); // 최소 힙
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] arr = Console.ReadLine().Split(" ");
            List<int> re = new List<int>();

            foreach (var num in arr)
                re.Add(int.Parse(num));

            if (pq.Count > 0) // 큐에 값이 있을 때
            {
                foreach (var j in re)
                {
                    if (j > pq.Peek()) // 가장 작은 값보다 크면 교체
                    {
                        pq.Dequeue(); // 최소값 제거 (O(logN))
                        pq.Enqueue(j, j); // 새 값 추가 (O(logN))
                    }
                }
            }
            else // 큐가 비어있을 경우
            {
                foreach (var s in re)
                    pq.Enqueue(s, s);
            }
        }

        Console.WriteLine(pq.Peek()); // 최솟값 출력
        }
    }
}
