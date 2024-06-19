using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
       
         for (int i = 0; i < s.Length; i++)
         {
             for (int j = i + 1; j < s.Length; j++)
             {
                 if (s[i] == s[j])
                 {
                     s = s.Replace(s[i], ' ');
                 }
             }
         }

        char[] arr = s.ToCharArray();
         Array.Sort(arr);

         for(int i = 0; i < s.Length; i++)
         {
             if (arr[i] == ' ')
             {
                 continue;
             }
             else
             {
                 answer += arr[i];
             }
         }
       
        return answer;
    }
}