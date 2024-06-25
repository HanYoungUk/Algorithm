using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] baby = { "aya", "woo", "ye", "ma" };

        for(int i = 0; i < babbling.Length; i++)
        {
           for(int j = 0; j < baby.Length; j++)
            {
                if (babbling[i].Contains(baby[j]))
                {
                    babbling[i] = babbling[i].Replace(baby[j],".");
                }
            }
        }

          foreach (string s in babbling)
          {
              string str = ".";
              string a = "";
              for(int i = 0; i < s.Length; i++)
              {
                 a += str;
              }
              if (s.Equals(a))
              {
                  answer++;
              }
          }
       
       
        return answer;
    }
}