using System;

public class Solution {
    public int solution(int price) {
        int answer = 0;
        double price2 = price;
       
             if (price >= 100_000 && price < 300_000)
             {
                double num = price * 0.05;
                answer = (int)(price2 - num);
             }
             else if(price >= 300_000 && price < 500_000)
             {
                double num = price * 0.1;
                answer = (int)(price - num);
             }
             else if(price >= 500_000)
             {
                double num = price * 0.2;
                answer = (int)(price - num);
             }
             else
             {
                answer = price;
             }
        return answer;
    }
}