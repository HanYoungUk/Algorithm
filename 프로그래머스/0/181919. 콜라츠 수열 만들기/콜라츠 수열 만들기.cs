using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int n) {
        List<int> list = new List<int>();
       
         while (true)
         {
             list.Add(n);
             if(n == 1)
             {
                 break;
             }

             if(n % 2 == 0) // 짝수일 때
             {
                 n = n / 2;
             }
             else // 홀수일 때
             {
                 n = 3 * n + 1;
             }
         }
        return list;
    }
}