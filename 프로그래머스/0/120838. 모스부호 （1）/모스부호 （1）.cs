using System;

public class Solution {
    public string solution(string letter) {
        string answer = "";
       
        String[] arr = letter.Split(" ");
         for(int i = 0; i < arr.Length; i++){
            if (arr[i].Equals(".-")) answer += "a";
            if (arr[i].Equals("-...")) answer += "b";
            if (arr[i].Equals("-.-.")) answer += "c";
            if (arr[i].Equals("-..")) answer += "d";
            if (arr[i].Equals(".")) answer += "e";
            if (arr[i].Equals("..-.")) answer += "f";
            if (arr[i].Equals("--.")) answer += "g";
            if (arr[i].Equals("....")) answer += "h";
            if (arr[i].Equals("..")) answer += "i";
            if (arr[i].Equals(".---")) answer += "j";
            if (arr[i].Equals("-.-")) answer += "k";
            if (arr[i].Equals(".-..")) answer += "l";
            if (arr[i].Equals("--")) answer += "m";
            if (arr[i].Equals("-.")) answer += "n";
            if (arr[i].Equals("---")) answer += "o";
            if (arr[i].Equals(".--.")) answer += "p";
            if (arr[i].Equals("--.-")) answer += "q";
            if (arr[i].Equals(".-.")) answer += "r";
            if (arr[i].Equals("...")) answer += "s";
            if (arr[i].Equals("-")) answer += "t";
            if (arr[i].Equals("..-")) answer += "u";
            if (arr[i].Equals("...-")) answer += "v";
            if (arr[i].Equals(".--")) answer += "w";
            if (arr[i].Equals("-..-")) answer += "x";
            if (arr[i].Equals("-.--")) answer += "y";
            if (arr[i].Equals("--..")) answer += "z";
        }
        return answer;
    }
}