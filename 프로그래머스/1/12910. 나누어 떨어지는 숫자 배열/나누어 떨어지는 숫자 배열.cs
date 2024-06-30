using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
       
        List<int> answer = new List<int>();
       
         for(int i = 0; i < arr.Length; i++)
         {
             if (arr[i] % divisor == 0)
             {
                 answer.Add(arr[i]);
             }
         }
       
        if(answer.Count == 0)
         {
             answer.Add(-1);
         }

         int[] a = new int[answer.Count];


         for (int i = 0; i < a.Length; i++)
         {
             a[i] = answer[i];
         }

         Array.Sort(a);

        return a;
    }
}