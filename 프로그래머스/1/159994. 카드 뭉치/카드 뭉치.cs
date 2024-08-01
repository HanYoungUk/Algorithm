using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
       
        Stack<string> stack1 = new Stack<string>();
        Stack<string> stack2 = new Stack<string>();
        Array.Reverse(cards1);
        Array.Reverse(cards2);
        string answer = "Yes";
       
        foreach(string c in cards1)
        {
            stack1.Push(c);
        }
        foreach(string c in cards2)
        {
            stack2.Push(c);
        }

        for (int i = 0; i < goal.Length; i++)
        {
            string el1 = "";
            string el2 = "";
            if(stack1.Count > 0)
            {
                el1 = stack1.Peek(); // 스택에 제일 위 요소
            }
            if(stack2.Count > 0)
            {
                el2 = stack2.Peek();
            }
            if (el1.Equals(goal[i]))
            {
                stack1.Pop();
            }
            else if (el2.Equals(goal[i]))
            {
                stack2.Pop();
            }
            else
            {
                answer = "No";
                break;
            }
            el1 = ""; // 혹시 모르니 초기화
            el2 = "";
        }
       
        return answer;
    }
}