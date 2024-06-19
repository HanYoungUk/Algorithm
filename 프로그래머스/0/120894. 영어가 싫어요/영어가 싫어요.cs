using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
       string[] str = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i].Contains(str[i]))
            {
                numbers = numbers.Replace(str[i], $"{i}");
            }
        }

        answer = long.Parse(numbers);
       
        return answer;
    }
}