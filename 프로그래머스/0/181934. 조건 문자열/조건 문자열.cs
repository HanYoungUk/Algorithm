using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        int answer = 0;
       
        if(ineq == "<" & eq == "!") // < 일때
        {
            answer = n < m ? 1 : 0;
        }
        else if(ineq == ">" & eq == "!") // > 일때
        {
            answer = n > m ? 1 : 0;
        }
        else if(ineq == "<" & eq == "=")
        {
            answer = n <= m ? 1 : 0;
        }
        else
        {
            answer = n >= m ? 1 : 0;
        }
       
        return answer;
    }
}