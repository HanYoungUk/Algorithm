using System;

public class Solution {
    public int solution(string s) {
         char x = s[0]; // 첫글자이므로 s[0]을 대입
         int count1 = 1; // 첫번째 문자의 개수
         int count2 = 0; // 그 후 문자의 개수
         int answer = 0; // 결과를 담을 변수
         bool check = false; // 두 횟수가 같아지는 순간을 체크할 변수
       
        if(s.Length == 1)
        {
            return 1;
        }
       
         for (int i = 1; i < s.Length; i++)
         {
             if(check == true)
             {
                 x = s[i]; // 첫글자를 다시 대입
                 check = false; // check를 false로 변경
             }

             if(x == s[i]) // x와 s[i]가 같을 경우
             {
                 count1++; // count1을 올려줌
             }
             else // 다를 경우
             {
                 count2++; // count2를 올려줌
             }

             if(count1 == count2) // 두 횟수가 같을 경우
             {
                 answer++; // 결과값 증가
                 count1 = 0; // count1 초기화
                 count2 = 0; // count2 초기화
                 check = true; // check를 true로 변경
             }
             if(s.Length -1 == i && count1 != count2) // 두 횟수가 다를 경우
             {
                 answer++; // 결과값 증가
             }
         }
        return answer;
    }
}