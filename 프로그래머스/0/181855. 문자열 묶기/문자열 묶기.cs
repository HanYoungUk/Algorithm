using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] strArr) {
        int answer = 0;
       
        List<int> list = new List<int>();
        int count = 0;
        for(int i = 1; i <= 30; i++)
        {
            count = 0;
            if(i == strArr.Length)
            {
                break;
            }
            for(int j = 0; j < strArr.Length; j++)
            {
                if(i == strArr[j].Length)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                list.Add(count);
            }

        }
        list.Sort();
        return answer = list[list.Count - 1];
    }
}
