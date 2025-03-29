using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
              List<int> list = new List<int>();
              for(int i = 0; i < 5; i++)
              {
                  int x = Int32.Parse(Console.ReadLine());

                  list.Add(x);
              }
              int total = list[0]; // 방학일
              int korea = list[1]; // 국어 숙제
              int math = list[2]; // 수학 숙제
              int homekorea = list[3]; // 국어 최대 페이지
              int homemath = list[4]; // 수학 최대 페이지

              int koreavalue = korea / homekorea; // 일자 계산
              int mathvalue = math / homemath; // 일자 계산

              if (koreavalue > mathvalue)
              {
                  if (korea % homekorea == 0)
                  {
                      Console.WriteLine(total - koreavalue);
                  }
                  else
                  {
                      Console.WriteLine(total - koreavalue - 1);
                  }
              }
              else if (koreavalue < mathvalue)
              {
                  if (math % homemath == 0)
                  {
                      Console.WriteLine(total - mathvalue);
                  }
                  else
                  {
                      Console.WriteLine(total - mathvalue - 1);
                  }
              }
              else // 일자가 같을 경우
              {
                  if(korea % homekorea == 0 &&  math % homemath == 0)
                  {
                      Console.WriteLine(total - mathvalue);
                  }
                  else
                  {
                      Console.WriteLine(total - mathvalue - 1);
                  }
              }
        }
    }
}
