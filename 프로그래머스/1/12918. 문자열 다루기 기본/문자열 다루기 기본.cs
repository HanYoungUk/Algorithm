public class Solution {
    public bool solution(string s) {
        bool answer = false;
       
         if(s.Length == 4 || s.Length == 6)
 {
     for(int i = 0; i < s.Length; i++)
     {
         if (s[i] >= 48 && s[i] <= 57)
         {
             answer = true;
         }
         else
         {
             answer = false;
             break;
         }
     }
 }
        return answer;
    }
}
