using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<int> solution(int[] arr, int[] query) {
       
         List<int> list = arr.ToList();
         for (int i = 0; i < query.Length; i++)
        {
            if(i % 2 == 0) // 짝수이면
            {
                list.RemoveRange(query[i] + 1, list.Count - 1 - query[i]);
            }
            else // 홀수이면
            {
                list.RemoveRange(0, query[i]);
            }
        }
       
        return list;
    }
}