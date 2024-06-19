using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(string my_string) {
       
        List<int> list = new List<int>();
        for(int i = 0; i < my_string.Length; i++)
        {
            if (my_string[i] >= 48 && my_string[i] <= 57)
            {
                list.Add(my_string[i] - '0');
            }
        }

        list.Sort();
       
        return list;
    }
}
