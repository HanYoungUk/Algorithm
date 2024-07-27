using System;

public class Solution {
    public int solution(int[] num_list) {
        int sum = 0;
        for(int i = 0; i < num_list.Length; i++)
        {
            int count = 0;
            while (true)
            {
                if (num_list[i] == 1)
                {
                    break;
                }
                if (num_list[i] % 2 == 0) // 짝수일경우
                {
                    num_list[i] = num_list[i] / 2;
                    count++;
                }
                else
                {
                    num_list[i] = (num_list[i] - 1) / 2;
                    count++;
                }
            }
            sum += count;
        }
        return sum;
    }
}
