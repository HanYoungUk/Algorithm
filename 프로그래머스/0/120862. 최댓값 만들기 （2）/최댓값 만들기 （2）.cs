using System;
using System.Collections.Generic;

public class Solution {
    public long solution(int[] numbers) {
      long max = numbers[0] * numbers[1];;
        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] * numbers[j] > max)
                {
                    max = numbers[i] * numbers[j];
                }
            }
        }
                return max;
    }
}
