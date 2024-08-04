using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        Stack<int> stack = new Stack<int>();

        // 3진법 만들기
        string result = "";
        while (n > 0)
        {
            int remainder = n % 3;
            result = remainder.ToString() + result;
            n /= 3;
        }
        // 스택에 담기
        for(int i = 0; i < result.Length; i++)
        {
            stack.Push(result[i] - '0');
        }

        for(int i = 0; i < result.Length; i++)
        {
            answer += stack.Pop() * (int)Math.Pow(3, result.Length - 1 - i);
        }
       
       
        return answer;
    }
}