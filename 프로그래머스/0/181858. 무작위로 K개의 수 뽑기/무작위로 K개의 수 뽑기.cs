using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int k) {
         HashSet<int> list = new HashSet<int>();
         int[] answer = new int[k];

         for(int i = 0; i < arr.Length; i++)
         {
             list.Add(arr[i]);
         }

         if(list.Count < k)
         {

             for(int i = 0; i < k; i++)
             {
                 answer[i] = -1;
             }
             for(int i = 0; i < list.Count; i++)
             {
                answer[i] = list.ElementAt(i);
             }
         }
         else
         {
             int number = 0;
             foreach(int i in list)
             {
                 if(number == k)
                 {
                     break;
                 }
                 else
                 {
                     answer[number] = i;
                     number++;
                 }
             }

         }
        return answer;
    }
}
