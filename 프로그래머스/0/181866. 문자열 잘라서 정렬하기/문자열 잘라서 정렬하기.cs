using System;
using System.Collections.Generic;

public class Solution {
    public List<string> solution(string myString) {
       
         string[] ss = myString.Split("x");
         List<string> list = new List<string>();

         for(int i = 0; i < ss.Length; i++)
         {
             if (ss[i].Length == 0)
             {
                 continue;
             }
             else
             {
                 list.Add(ss[i]);
             }
         }
        list.Sort();
       
        return list;
    }
}
