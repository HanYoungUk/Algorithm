using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
       
       
        for(int i = 0; i < myString.Length; i++)
        {
            if (myString[i] == 'a' || myString[i] == 'A')
            {
                answer += "A";
            }
            else if (myString[i] >= 65 && myString[i] <= 90)
            {
                answer += (char)(myString[i] + 32);
            }
            else
            {
                answer += myString[i];
            }

        }
        return answer;
    }
}
