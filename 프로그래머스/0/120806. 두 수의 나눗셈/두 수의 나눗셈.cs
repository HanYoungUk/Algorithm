using System;

public class Solution {
    public int solution(int num1, int num2) {
       
        double x = (double)num1 / (double)num2;
        double answer = x * 1000;
       
        return (int)answer;
    }
}