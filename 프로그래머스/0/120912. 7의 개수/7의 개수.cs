using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
       
      List<string> list = new List<string>();

        for(int i = 0; i < array.Length; i++)
        {
          list.Add(array[i].ToString());
        }

        for(int i = 0; i < list.Count; i++)
        {
            for(int j = 0; j < list[i].Length; j++)
            {
                if (list[i][j] == '7')
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}
