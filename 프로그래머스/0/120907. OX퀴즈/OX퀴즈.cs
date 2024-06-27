using System;
using System.Collections.Generic;

public class Solution {
    public List<string> solution(string[] quiz) {

        List<string> list = new List<string>();
        for(int i = 0; i < quiz.Length; i++)
        {
            string[] arr = quiz[i].Split(" ");

            int num1 = Int32.Parse(arr[0]);
            int num2 = Int32.Parse(arr[2]);
            string op = arr[1];
            int result = Int32.Parse(arr[4]);

            if (op.Equals("+"))
            {
                if(result == num1 + num2)
                {
                    list.Add("O");
                }
                else
                {
                    list.Add("X");
                }
            }
            else
            {
                if (result == num1 - num2)
                {
                    list.Add("O");
                }
                else
                {
                    list.Add("X");
                }
            }
        }
       
        return list;
    }
}