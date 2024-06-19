using System.IO;
using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        double a = Math.Sqrt(n);
        var str = Math.Sqrt(n).ToString();
       
        if(str.Contains(".")){
            answer = -1;
        } else{
            answer = (long)((a + 1) * (a + 1));
        }
       
        return answer;
    }
}