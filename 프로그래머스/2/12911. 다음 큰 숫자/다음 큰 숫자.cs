using System;

class Solution
{
    public int solution(int n)
   {
       string x = Convert.ToString(n, 2);
        int count = 0;
        int answer = 0;
        for(int i = 0; i < x.Length; i++)
        {
            if (x[i] == '1')
            {
                count++;
            }
        }

        for(int i = n + 1; i <= 1_000_000; i++)
        {
            string y = Convert.ToString(i, 2);
            int count2 = 0;
            for(int j = 0; j < y.Length; j++)
            {
                if (y[j] == '1')
                {
                    count2++;
                }
            }
            if(count2 == count)
            {
                answer = i;
                break;
            }
        }

        return answer;
    }
}