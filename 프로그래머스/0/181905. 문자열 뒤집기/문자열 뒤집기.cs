using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int s, int e) {
       var str = "";
        for(int i = s; i <= e; i++)
        {
            str += my_string[i];
        }

        string newstr = new string(str.Reverse().ToArray());
        int x = s;
        string answer = "";
        int count = 0;
        for (int i = 0; i < my_string.Length; i++)
        {

            if (x == i)
            {
                answer += newstr[count++];

                if (count > newstr.Length - 1)
                {
                    continue;
                }
                x++;
            }
            else
            {
                answer += my_string[i];
            }
        }
        return answer;
    }
}
