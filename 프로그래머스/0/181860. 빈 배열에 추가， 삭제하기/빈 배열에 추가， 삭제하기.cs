
using System;
using System.Collections.Generic;

public class Solution {
    public Stack<int> solution(int[] arr, bool[] flag) {
       
        Stack<int> stack = new Stack<int>();
        for(int i = 0; i < flag.Length; i++)
        {
            if (flag[i] == true)
            {
                for(int j = 1; j <= arr[i] * 2; j++)
                {
                    stack.Push(arr[i]);
                }
            }
            else
            {
                for(int j = 1; j <= arr[i]; j++)
                {
                    stack.Pop();
                }
            }
        }
        Stack<int> restack = new Stack<int>();
        while(stack.Count != 0)
        {
            restack.Push(stack.Pop());
        }
        return restack;
    }
}