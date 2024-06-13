using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        string s1 = "";
       
        for(int i = 0; i < my_string.Length; i++)
        {
          s1 = $"{my_string[num1]}";
           if(i == num1)
            {
               answer += my_string[num2];
            } else if(i == num2)
            {
                answer += s1;
            }
            else
            {
                answer += my_string[i];    
            }
        }

       
        return answer;
    }
}