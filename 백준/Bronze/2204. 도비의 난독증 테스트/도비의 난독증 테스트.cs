using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
             StringBuilder sb = new StringBuilder();
             while (true)
             {
                 // 몇번 입력받을건지 선택
                 int count = int.Parse(Console.ReadLine());

                 // 0이면멈춤
                 if(count == 0)
                 {
                     break;
                 }

                 List<string> list = new List<string>();
                 for(int i = 0; i < count; i++)
                 {
                     // 단어를 입력받음
                     string str = Console.ReadLine();
                     list.Add(str);
                 }
                 // 오름차순 정렬
                 list.Sort(StringComparer.OrdinalIgnoreCase);;

                 sb.AppendLine(list[0]);
             }
             Console.WriteLine(sb.ToString());
        }
    }
}