using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        int count = 0;
        string[] arr1 = new string[before.Length];
        string[] arr2 = new string[after.Length];
       
        for (int i = 0; i < before.Length; i++)
         {
             arr1[i] = $"{before[i]}";
         }
         for (int i = 0; i < after.Length; i++)
         {
             arr2[i] = $"{after[i]}";
         }

         Array.Sort(arr1);
         Array.Sort(arr2);

         for(int i = 0; i < arr1.Length; i++)
         {
             if (arr1[i] == arr2[i])
             {
                 count++;
             }
         }
         if(count == arr1.Length)
         {
             answer = 1;
         } else
         {
             answer = 0;
         }
       
       
        return answer;
    }
}