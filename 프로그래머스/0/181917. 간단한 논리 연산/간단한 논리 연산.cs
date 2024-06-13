using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = true;
        bool y1 = true;
        bool y2 = true;
        if(x1 == false && x2 == false){
            y1 = false; // x1,x2계산
        } else {
            y1 = true;
        }
       
        if(x3 == false && x4 == false){
            y2 = false; // x3, x4계산
        } else{
            y2 = true;
        }
       
        if(y1 == true && y2 == true){
            answer = true;
        } else{
            answer = false;
        }
        return answer;
    }
}