using System;

public class Solution {
    public string solution(string my_string) {
        my_string = my_string.ToLower();
        char[] arr = my_string.ToCharArray();

        Array.Sort(arr);
        string answer = "";
       
        foreach(char c in arr){
            answer += c;
        }
       
        return answer;
    }
}