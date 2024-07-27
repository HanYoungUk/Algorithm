using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public List<int> solution(int[] arr, int[,] queries) {
        List<int> answer = new List<int>();
       
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            int count = 0;
            List<int> list = new List<int>();
            for (int j = queries[i,0]; j <= queries[i,1]; j++)
            {
                if (queries[i, 2] < arr[j])
                {
                    list.Add(arr[j]);
                    count++;
                }
            }
            if(count == 0)
            {
                list.Add(-1);
            }
            answer.Add(list.Min());
        }
        return answer;
    }
}