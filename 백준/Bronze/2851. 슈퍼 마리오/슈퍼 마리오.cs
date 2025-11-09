using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int sum = 0;


            bool check = false;
            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());

                sum += num;

                if (check == false)
                {
                    if (sum >= 100)
                    {
                        check = true;
                        if (sum == 100) // sum이 100일 경우
                        {
                            sb.AppendLine(sum.ToString());
                        }
                        else // 100을 넘을 경우
                        {
                            // 비교하기
                            if (100 - (sum - num) < sum - 100)
                            {
                                sb.AppendLine((sum - num).ToString());
                            }
                            else if (100 - (sum - num) > sum - 100)
                            {
                                sb.AppendLine(sum.ToString());
                            }
                            else // 둘이 같을 경우
                            {
                                sb.AppendLine(sum.ToString());
                            }
                        }
                    }
                }
                
                if (i == 9 && sum < 100)
                {
                    sb.Append(sum.ToString());
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
