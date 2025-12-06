using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int consonant = 0; // 자음
                int vowel = 0; // 모음

                string str = Console.ReadLine().ToLower();

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[j] == 'a' || str[j] == 'e' || str[j] == 'i' || str[j] == 'o' || str[j] == 'u')
                    {
                        vowel++;
                    }
                    else if (str[j] >= 97 && str[j] <= 122)
                    {
                        consonant++;
                    }
                }

                sb.AppendLine($"{consonant} {vowel}");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
