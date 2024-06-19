using System;

public class Solution {
    public int[] solution(string my_string) {
                char[] arr =            {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        int[] answer = new int[52];

        for(int i = 0; i < arr.Length; i++)
        {
            int count = 0;
            for (int j= 0; j < my_string.Length; j++)
            {
                if (arr[i] == my_string[j])
                {
                    count++;
                }
            }
            answer[i] = count;
        }
       
        return answer;
    }
}