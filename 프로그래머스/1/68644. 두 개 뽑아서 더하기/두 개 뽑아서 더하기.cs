using System;
using System.Collections.Generic;

public class Solution {
    public SortedSet<int> solution(int[] numbers) {
       
        SortedSet<int> list = new SortedSet<int>();
        for(int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                list.Add(numbers[i] + numbers[j]);
            }
        }
       
        return list;
    }
}