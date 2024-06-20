using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        List<string> list1 = new List<string>(); // 소문자용
        List<string> list2 = new List<string>(); // 대문자용
        string answer = "";

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 97 & s[i] <= 122)
                list1.Add($"{s[i]}");
            else
                list2.Add($"{s[i]}");
        };

        list1.Sort();
        list1.Reverse();
        list2.Sort();
        list2.Reverse();

        foreach(string a in list1)
        {
            answer += a;
        }
        foreach(string a in list2)
        {
            answer += a;
        }
        return answer;
    }
}