using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list = new List<int>(); // 결과들을 담을 list
            Stack<int> stack = new Stack<int>(); // 스택을 만듬
            for(int i = 0; i < N; i++)
            {
                string x = Console.ReadLine();

                if (x.Contains("push"))
                {
                    string[] arr = x.Split(" "); // push의 문장을 나눠줌

                    int num = int.Parse(arr[1]); // 숫자부분 만듬

                    stack.Push(num);
                }
                else if (x.Equals("top")) // 제일 위에 있는거 출력
                {
                    if (stack.Count > 0) // 0이면 -1를 호출
                    {
                        int num = stack.Pop(); // 일단 빼내고 다시 넣을거임
                        list.Add(num);
                        stack.Push(num); // 다시 넣음
                    }
                    else // 0일 경우
                    {
                        list.Add(-1);
                    }
                }
                else if (x.Equals("size"))
                {
                    list.Add(stack.Count);
                }
                else if(x.Equals("empty"))
                {
                    if (stack.Count > 0) // 0이 아닐 경우
                    {
                        list.Add(0);
                    }
                    else // 0일 경우
                    {
                        list.Add(1);
                    }
                }
                else
                {
                    if(stack.Count > 0) // 스택이 안비어있을 때
                    {
                        int num = stack.Pop();

                        list.Add(num);
                    }
                    else // 비어 있을 때
                    {
                        list.Add(-1);
                    }
        
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach(var i in list)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}