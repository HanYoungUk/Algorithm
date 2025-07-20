using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < count; i++)
            {
                Dictionary<int, int> dic = new Dictionary<int, int>();
                for (int j = 1; j <= 6; j++)
                {
                    dic.Add(j, 0);
                }

                string str = Console.ReadLine();

                string[] arr = str.Split(" ");

                for (int j = 0; j < arr.Length; j++) // 주사위 값들을 추가
                {
                    dic[int.Parse(arr[j])]++;
                }

                int oneCheck = 0;
                int twoCheck = 0;
                foreach (var j in dic)
                {
                    if (j.Value == 4) // 전부다 같을 경우
                    {
                        int result = 50_000 + j.Key * 5_000;
                        list.Add(result);
                        break;
                    }
                    else if (j.Value == 3) // 3개가 나왔을 경우
                    {
                        int result = 10_000 + j.Key * 1_000;
                        list.Add(result);
                        break;
                    }
                    else if (j.Value == 1) // 1개만 체크해서 나중에 계산
                    {
                        oneCheck++;
                        continue;
                    }
                    else if (j.Value == 2) // 2개만 체크해서 나중에 계산
                    {
                        twoCheck++;
                        continue;
                    }
                }
                if (twoCheck == 1)
                {
                    foreach (var j in dic)
                    {
                        if (j.Value == 2)
                        {
                            int result = 1_000 + j.Key * 100;
                            list.Add(result);
                            break;
                        }
                    }
                    continue;
                }
                else if (twoCheck == 2) // 2개일 경우
                {
                    List<int> twolist = new List<int>(); // 2개인걸 담을 리스트

                    foreach (var j in dic)
                    {
                        if (j.Value == 2)
                        {
                            twolist.Add(j.Key);
                        }
                    }
                    int result = 2_000 + twolist[0] * 500 + twolist[1] * 500;
                    list.Add(result);
                    continue;
                }
                if (oneCheck == 4) // 다 다른 경우
                {
                    int max = 0;
                    foreach (var j in dic) // 최대 값 찾을려고 씀.
                    {
                        if(j.Value == 1)
                        {
                            max = j.Key;
                        }
                    }
                    int result = max * 100;
                    list.Add(result);
                    continue;
                }
            }
            list.Sort();
            Console.WriteLine(list[list.Count - 1]);
        }
    }
}
