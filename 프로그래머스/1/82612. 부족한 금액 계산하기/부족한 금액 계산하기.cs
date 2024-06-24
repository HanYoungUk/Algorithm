using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long answer = 0;
        long sum = 0;
       
        for(int i = 1; i <= count; i++)
        {
            long a = price * i;
            sum += a;
        }
        if(sum <= money)
        {
            answer = 0;
        }
        else
        {
            answer = sum - money;
        }
       
        return answer;
    }
}