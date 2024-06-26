using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string) {
        string str = "";
    List<int> list = new List<int>();
    for(int i = 0; i < my_string.Length; i++)
    {
   
        if (my_string[i] >= 48 && my_string[i] <= 57) // 숫자 일경우
        {
           str += my_string[i];
            if(i == my_string.Length - 1)
            {
                list.Add(Int32.Parse(str));
            }
        }
        else // 글자일경우
        {
            if (str.Equals(""))
            {
                continue;
            }
            int num = Int32.Parse(str);
            list.Add(num);
            str = "";
        }
    }
    int answer = 0;
    foreach(int i in list)
    {
        answer += i;
    }
       
        return answer;
    }
}