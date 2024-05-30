using System;

public class Solution {
    public int solution(int[] num_list) {
        String answer = "";
        String answer1 = "";
        for(int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                answer += $"{num_list[i]}";
            }
            else
            {
                 answer1 += $"{num_list[i]}";
            }
        }

            int x = Int32.Parse(answer);
            int y = Int32.Parse(answer1);

            int sum = x + y;
       
        return sum;
    }
}