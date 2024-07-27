using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int l, int r) {
         List<int> list = new List<int>();
 
         for(int i = l; i <= r; i++)
         {
             int count = 0;
             string str = i.ToString();
             for(int j = 0; j < str.Length; j++)
             {
                 if (str[j] == '5' || str[j] == '0')
                 {
                     count++;
                 }
             }
             if (count == str.Length)
             {
                 list.Add(i);
             }
         }

         if(list.Count == 0)
         {
             list.Add(-1);
         }
       
       
        return list;
    }
}