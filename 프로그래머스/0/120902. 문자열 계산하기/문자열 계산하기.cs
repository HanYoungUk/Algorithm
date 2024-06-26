using System;

public class Solution {
    public int solution(string my_string) {
        string[] arr = my_string.Split(" ");
        int answer = Int32.Parse(arr[0]);

        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i].Equals("+"))
            {
                answer += Int32.Parse(arr[i + 1]);
                Console.WriteLine("+" + answer);
            }
            else if (arr[i].Equals("-"))
            {
                answer -= Int32.Parse(arr[i + 1]);
                Console.WriteLine("-" + answer);
            }
        }
        return answer;
    }
}