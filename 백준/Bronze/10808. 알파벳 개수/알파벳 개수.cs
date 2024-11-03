using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            List<char> list = new List<char>(); // 알파벳을 담을 리스트

            for(char c = 'a'; c <= 'z'; c++) // 알파벳을 담는용도
            {
                list.Add(c);
            }
            int[] arr = new int[list.Count]; // 결과를 담을 answer

            for (int i = 0; i < list.Count; i++)
            {
                int count = 0; // 몇개인지 알아낼 변수
    
                for(int j = 0; j < str.Length; j++)
                {
                    if (str[j] == list[i])
                    {
                        count++;
                    }
                }
                arr[i] = count;
            }
  


            foreach(var i in arr)
            {    
                Console.Write(i + " ");
            }   
        }
    }
}