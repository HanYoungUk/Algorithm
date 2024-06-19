using System;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Collections.Generic;

public class Solution {
    public long solution(long n) {
        long answer = 0;
       
        string str = n.ToString();
        string[] arr = new string[str.Length];

        for(int i = 0; i < str.Length; i++)
        {
            arr[i] = $"{str[i]}";
        }
        Array.Sort(arr);
        Array.Reverse(arr);
        str = "";
        foreach(string i in arr){
           str += i;
        }
       
        return answer = long.Parse(str);
    }
}