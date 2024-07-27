using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int[] arr) {
        List<string> list = new List<string>();
        List<int> answer = new List<int>();
        foreach(int i in arr)
        {
            list.Add(i.ToString());
        }

        int x = list.LastIndexOf("2");
        int x2 = list.IndexOf("2");

        if(x == -1)
        {
            answer.Add(-1);
        }
        else
        {
            for (int i = x2; i <= x; i++)
            {
                answer.Add(arr[i]);
            }
        }
       
        return answer;
    }
}