public class Solution {
    public int solution(long num) {
        int answer = 0;
       
       
       while(answer != 500)
        {
            if(num == 1)
            {
                break;
            }
            if(num % 2 == 0) // 짝수일 경우
            {
                num = num / 2;

            }
            else
            {
                num = num * 3 + 1;

            }
            answer++;
        }

        if(answer == 500)
        {
            answer = -1;
        }
       
        return answer;
    }
}