using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int[] arr) {
        int i = 0;
        List<int> list = new List<int>();

        while (i < arr.Length)
        {
            if (list.Count == 0)
            {
                list.Add(arr[i++]);

            }
            if (list.Count != 0 && list[list.Count - 1] < arr[i])
            {
                list.Add(arr[i++]);
            }
            else
            {
                list.RemoveAt(list.Count - 1);
            }
        }
        return list;
    }
}
