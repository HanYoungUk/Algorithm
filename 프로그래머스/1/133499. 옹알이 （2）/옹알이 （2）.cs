using System;

public class Solution {
    public int solution(string[] babbling) {


        string[] baby = { "aya", "ye", "woo", "ma" };
        string[] distinct = { "ayaaya","yeye","woowoo","mama"};
       
        int answer = 0;
        bool check = false;

       for (int i = 0; i < babbling.Length; i++)
        {
            foreach(string di in distinct)
            {
                if (babbling[i].Contains(di))
                {
                    check = true;
                    break;
                }
            }
            if(check == true)
            {
                check = false;
                continue;
            }
            foreach (string ba in baby)
            {
                if (babbling[i].Contains(ba))
                {
                    babbling[i] = babbling[i].Replace(ba, ".");
                }              
            }
            babbling[i] = babbling[i].Replace(".", "");
            if (babbling[i].Length == 0)
            {
                answer++;
            }

        }
       
        return answer;
    }
}