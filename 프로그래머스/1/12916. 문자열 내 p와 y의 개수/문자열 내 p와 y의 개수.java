class Solution {
    boolean solution(String s) {
        boolean answer = false;

        int p = 0;
        int y = 0;
        for(int i = 0; i < s.length(); i++)
        {
            if(s.charAt(i) == 'p' || s.charAt(i)  == 'P')
            {
                p++;
            }
            if(s.charAt(i)  == 'y' || s.charAt(i)  == 'Y')
            {
                y++;
            }
        }
       
       
        if(p == y)
        {
            answer = true;
        }
        else
        {
            answer = false;    
        }

        return answer;
    }
}