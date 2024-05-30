using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> list = new List<int>();

        for(int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                list.Add(i);
            }
        }

        int[] answer = list.ToArray(); // list를 복사해서 answer에 대입해주는거
       
       
        return answer;
    }
}