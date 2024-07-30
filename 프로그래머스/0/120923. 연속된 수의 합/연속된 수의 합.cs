using System;
using System.Collections.Generic;

public class Solution {
    public List<int> solution(int num, int total) {

        List<int> answer = new List<int>();
        int x = -400;
       
        if(num == 1){
            answer.Add(total);
            return answer;
        }
        else{
            while (x != total)
            {
                int sum = 0;
                List<int> list = new List<int>();
                for(int i = x; i < x + num; i++)
                {
                    sum += i;
                    list.Add(i);
                }
                if(sum == total)
                {
                    answer = list;
                    break;
                }
                x++;
            }

          return answer;
        }
    }
}