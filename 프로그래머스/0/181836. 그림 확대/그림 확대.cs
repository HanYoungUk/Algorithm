using System;
using System.Collections.Generic;

public class Solution {
    public List<string> solution(string[] picture, int k) {
         List<string> list = new List<String>();
         for(int i = 0; i < picture.Length; i++)
         {
             string str = "";
             for(int j = 0; j < picture[i].Length; j++)
             {
                 for(int x = 1; x <= k; x++)
                 {
                     str += picture[i][j];
                 }
             }
             for(int y = 1; y <= k; y++)
             {
                 list.Add(str);
             }
         }
        return list;
    }
}
