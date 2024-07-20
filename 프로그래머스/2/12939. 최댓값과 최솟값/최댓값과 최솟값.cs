using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string[] arr = s.Split(' ');
        List<int> list = new List<int>();

        foreach(string item in arr)
        {
            list.Add(Int32.Parse(item));
        }

        int max = list.Max();
        int min = list.Min();

        string answer = $"{min} {max}";
       
        return answer;
    }
}