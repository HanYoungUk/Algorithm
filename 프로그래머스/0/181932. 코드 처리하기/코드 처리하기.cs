using System;

public class Solution {
    public string solution(string code) {
        string answer = "";
        int mode = 0;
       
         for(int i = 0; i < code.Length; i++)
         {
             if (code[i] == '1' && mode == 0)
             {
                 mode = 1;
                 continue;
             }
             else if (code[i] == '1' && mode == 1)
             {
                 mode = 0;
                 continue;
             }

             if(mode == 0 && i % 2 == 00) // 모드가 0이고 짝수일 때
             {

                 answer += code[i];
             } else if(mode == 1 && i % 2 == 1)
             {
                 answer += code[i];
             }
         }
        if(answer.Equals("")){
            answer =  "EMPTY";
        }
       
        return answer;
    }
}