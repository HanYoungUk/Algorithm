using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        List<int> list = new List<int>();
        int answer = 0;
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
       
        for(int i = 0; i < rank.Length; i++)
        {
            if (attendance[i] == true)
            {
                list.Add(rank[i]);
            }
        }
        list.Sort();
       
        for (int i = 0; i < rank.Length; i++)
        {

            if (list[0] == rank[i])
            {
                num1 = i;
            }
            else if (list[1] == rank[i])
            {
                num2 = i;

            }
            else if (list[2] == rank[i])
            {
                num3 = i;
            }
            answer = (num1 * 10000) + (num2 * 100) + num3;
        }
        return answer;
    }
}