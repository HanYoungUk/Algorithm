using System;

public class Solution {
    public string solution(int age) {
        string str = age.ToString();
        string[] arr = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"};
       
        for(int i = 0; i < arr.Length; i++){
            str = str.Replace($"{i}", arr[i]);
        }
        return str;
       
    }
}