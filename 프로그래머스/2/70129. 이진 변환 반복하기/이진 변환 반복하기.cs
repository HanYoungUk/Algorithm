using System;

public class Solution {
    public int[] solution(string s) {
        string str = "";
        int count = 0; // 0을 제거한 횟수
        int[] answer = new int[2];
        int count2 = 1; // 반복한 횟수
        bool check = false;
       
        while (true)
        {
            string str2 = "";
            if (check == false)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '0')
                    {
                        count++;
                        continue;
                    }
                    str += s[i];
                }
                check = true;
            }
            else
            {
                for(int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '0')
                    {
                        count++;
                        continue;
                    }
                    str2 += str[i];
                }
            }
            if(str2.Length == 0)
            {
                int length = str.Length;
                str = Convert.ToString(length, 2);
            }
            else
            {
                str = str2;
                int length = str.Length;
                str = Convert.ToString(length, 2);
            }

            if (str.Equals("1"))
            {
                answer[0] = count2;
                answer[1] = count;
                break;
            }
            count2++;
        }
       
        return answer;
    }
}