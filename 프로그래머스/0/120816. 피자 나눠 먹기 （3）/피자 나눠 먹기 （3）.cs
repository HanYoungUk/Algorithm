using System;

public class Solution {
    public int solution(int slice, int n) {
        int answer = 0;
       
        // 사람마다 최소 한조각씩 먹어야한다.
       
        if(n % slice != 0){
            answer = n / slice + 1;
        } else {
            answer = n / slice;
        }
       
        return answer;
    }
}