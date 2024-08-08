using System;
using System.Linq;

public class Solution {
    public string solution(int[] food) {
        int[] number = new int[food.Length - 1];
        string answer = "";

        for(int i = 1; i < food.Length; i++)
        {
            int eat = food[i] / 2; // 둘이 나눠서 먹어야 하므로
            number[i - 1] = eat;
        }

        for (int i = 0; i < number.Length; i++)
        {
            int count = i + 1; // 먹는 음식은 1부터 시작하므로
            for(int j = 0; j < number[i]; j++)
            {
                answer += count;
            }
        }
        string reverse = new string(answer.Reverse().ToArray());
        answer += 0; // 마지막에 서로 물(0)을 먹어야하므로
        answer += reverse;
       
        return answer;
    }
}