using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = new int[numbers.Length];


        if (direction.Equals("left"))
        {
            int count = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (count == numbers.Length)
                {
                    count = 0;
                }
                answer[i] = numbers[count++];
            }
        }
        else if(direction.Equals("right"))
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    answer[i] = numbers[numbers.Length - 1];
                    continue;
                }
                answer[i] = numbers[count++];
            }

        }
        return answer;
    }
}
