using System;

public class Solution {
    public int solution(string binomial) {
        int answer = 0;
       
        if (binomial.Contains("+"))
        {
            string[] arr = binomial.Split("+");
            answer = Int32.Parse(arr[0]) + Int32.Parse(arr[1]);
        } else if (binomial.Contains("-"))
        {
            string[] arr = binomial.Split("-");
            answer = Int32.Parse(arr[0]) - Int32.Parse(arr[1]);
        }
        else
        {
            string[] arr = binomial.Split("*");
            answer = Int32.Parse(arr[0]) * Int32.Parse(arr[1]);
        }
       
       
        return answer;
    }
}
