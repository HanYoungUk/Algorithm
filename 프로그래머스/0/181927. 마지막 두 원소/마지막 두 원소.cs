using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public List<int> solution(int[] num_list) {
        int x = num_list[num_list.Length - 1];
        int y = num_list[num_list.Length - 2];
        List<int> list = num_list.ToList();
        if(x > y)
        {
            list.Add(x - y);
        }
        else
        {
            list.Add(x * 2);
        }
       
       
        return list;
    }
}
