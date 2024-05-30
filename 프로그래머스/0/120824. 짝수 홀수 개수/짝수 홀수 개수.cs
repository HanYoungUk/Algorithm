using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[2];
        int x = 0;
        int y = 0;


        for (int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                x++;
            }
            else
            {
                y++;
            }
        }
        answer[0] = x;
        answer[1] = y;
       
       
       
        return answer;
    }
}