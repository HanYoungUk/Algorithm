using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<string> solution(string my_string) {
       
        List<string> list = new List<string>();
        int count = 1;
        string str = "";
        for(int i = my_string.Length - 1; i >= 0; i--)
        {
            str += my_string[i];

            string newStr = new string(str.Reverse().ToArray());
            if (str.Length == count++)
            {
                list.Add(newStr);
            }
        }
        list.Sort();
       
       
        return list;
    }
}
