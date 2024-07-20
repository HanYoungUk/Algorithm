using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
         HashSet<int> hash = new HashSet<int>();
         for(int i = 0; i < array.Length; i++)
         {
             hash.Add(array[i]);
         }
         List<int> list = new List<int>();


         for(int i = 0; i < hash.Count; i++)
         {
             int count = 0;
             for (int j = 0; j < array.Length; j++)
             {
                 if (hash.ElementAt(i) == array[j])
                 {
                 count++;
                 }
             }
         list.Add(count);
         }

         int answer = 0;
         int num = 0;
         bool state = false;
         int max = list.Max();
         foreach (int i in list)
         {
             if(i == max)
             {
                 num++;
                 if(num > 1)
                 {
                     state = true;
                     break;
                 }
             }

         }
         if(state == true)
         {
             answer = -1;
         }
         else
         {
             int index = list.IndexOf(max);
             answer = hash.ElementAt(index);
         }
        return answer;
    }
}