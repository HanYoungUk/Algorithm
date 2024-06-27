using System;
using System.Numerics;

public class Solution {
    public string solution(int num) {
        string answer = "";
        num = Math.Abs(num);
        if(num % 2 == 1){
            answer = "Odd";
        } else {
            answer = "Even";
        }
       
        return answer;
    }
}