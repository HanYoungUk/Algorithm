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
        List<string> list = new List<string>();
        int index = 0;

        // 끝말잇기 기록 입력
        for (int i = 0; i < count; i++)
        {
            string xo = Console.ReadLine();
            if (xo == "?") index = list.Count;
            list.Add(xo ?? ""); // null 방지
        }

        // 후보 단어 입력
        int candidateCount = int.Parse(Console.ReadLine());
        List<string> candidates = new List<string>();
        for (int i = 0; i < candidateCount; i++)
        {
            string word = Console.ReadLine();
            if (!string.IsNullOrEmpty(word))
                candidates.Add(word);
        }

        string result = "";

        foreach (var word in candidates)
        {
            // 중복 체크: 기존 기록에서 '?' 제외
            if (list.Contains(word)) continue;

            bool valid = true;

            // 앞 글자 체크
            if (index > 0 && list[index - 1].Length > 0)
            {
                if (list[index - 1][^1] != word[0]) // ^1 = 마지막 글자
                    valid = false;
            }

            // 뒤 글자 체크
            if (index < list.Count - 1 && list[index + 1].Length > 0)
            {
                if (list[index + 1][0] != word[^1])
                    valid = false;
            }

            if (valid)
            {
                result = word;
                break; // 첫 번째 조건 만족 후보 선택
            }
        }

        Console.WriteLine(result);
        }
    }
}
