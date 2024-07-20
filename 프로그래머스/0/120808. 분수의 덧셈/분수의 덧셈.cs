using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
          int[] answer = new int[2];

        if(denom1 % denom2 == 0 || denom2 % denom1 == 0)
        {
            if(denom1 > denom2)
            {
                int num1 = denom1;
                int x1 = num1 / denom1;
                int x2 = num1 / denom2;

                int num2 = x1 * numer1 + x2 * numer2;
                answer[1] = num1;
                answer[0] = num2;
            }
            else
            {
                int num1 = denom2;
                int x1 = num1 / denom1;
                int x2 = num1 / denom2;

                int num2 = x1 * numer1 + x2 * numer2;
                answer[1] = num1;
                answer[0] = num2;
            }
        }
        else
        {
            int num1 = denom1 * denom2; // 분모
            int x1 = num1 / denom1; // 첫번째 분자에 곱할거
            int x2 = num1 / denom2; // 두번째 분자에 곱할거

            int num2 = x1 * numer1 + x2 * numer2;
            answer[1] = num1; // 분모
            answer[0] = num2; // 분자
        }
        int b = answer[0];
        int a = answer[1];
        while ( b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        answer[0] = answer[0] / a;
        answer[1] = answer[1] / a;
       
        return answer;
    }
}