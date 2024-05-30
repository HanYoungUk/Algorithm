using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
       
        int two = 2 * a * b;
       
      String x = a.ToString();
      String y = b.ToString();
       String xy = x + y;
        int one = Int32.Parse(xy);
       
        if(one >= two){
            answer = one;
        }
        else {
            answer = two;
        }
        return answer;
    }
}