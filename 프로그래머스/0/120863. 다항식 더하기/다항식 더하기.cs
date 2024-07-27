using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string polynomial) {
         string[] arr = polynomial.Split("+");
         List<int> number = new List<int>();
         List<string> xnumber = new List<string>();
         string answer = "";
         int sum = 0;
         int num = 0;
         for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Contains("x"))
            {
                xnumber.Add(arr[i]);
            }
            else
            {
                number.Add(Int32.Parse(arr[i]));
            }
        }
        foreach(int i in number)
        {
            sum += i; // 상수는 구함
        }
        number.Clear();

        for (int i = 0; i < xnumber.Count; i++)
        {
            string str = "";
            xnumber[i] = xnumber[i].Trim();
            for (int j = 0; j < xnumber[i].Length; j++)
            {
                if (xnumber[i].Length == 1)
                {
                    str = "1";
                }
                if (xnumber[i][j] == 'x')
                {
                    number.Add(Int32.Parse(str));
                    continue;
                }
                    str += xnumber[i][j];
            }
        }
        foreach(int i in number)
        {
            num += i;
        }
        if (num == 0)
        { // 상수만 있을 때
            answer = $"{sum}";
        }
        else if(sum == 0)
        { // x항만 있을 때
            if(num == 1)
            {
                answer = $"x";
            }
            else
            {
                answer = $"{num}x";
            }
        }
        else
        {
            if(num == 1)
            {
                answer = $"x + {sum}";
            }
            else
            {
                answer = $"{num}x + {sum}";
            }
        }
        return answer;
    }
}