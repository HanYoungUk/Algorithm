public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        int x = 0;
        for (int i = 0; i < s.Length; i++)
        {
          if (s[i] == ' ')
            {
                answer += ' ';
            }
            else if (s[i] + n > 122)
            {
                x = s[i] + n - 122 + 97 -1;
                answer += (char)x;
            }
            else if (s[i] + n > 90 & s[i] >= 65 & s[i] <= 90)
            {
                x = s[i] + n - 90 + 65 -1;
                answer += (char)x;
            }
            else
            {
                x = s[i] + n;
                answer += (char)x;
            }
        }
       
        return answer;
    }
}
