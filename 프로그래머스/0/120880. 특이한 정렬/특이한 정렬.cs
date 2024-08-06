using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int[] numlist, int n) {
        List<int> list = new List<int>();
        List<int> answer = new List<int>();
        Array.Sort(numlist);
        for(int i = 0; i < numlist.Length; i++)
        {
            if (numlist[i] > n)
            {
                list.Add(numlist[i] - n);
            }
            else if (numlist[i] < n)
            {
                list.Add(n - numlist[i]);
            }
            else
            {
                list.Add(0);
            }
        }
        int x = 0;
        while (true)
        {
            for(int j = list.Count - 1; j >= 0; j--)
            {
                if(x == list[j])
                {
                    answer.Add(numlist[j]);
                }
            }
            x++;
            if(answer.Count == numlist.Length)
            {
                break;
            }
        }
        return answer;
    }
}