using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "";
       
        for (int i = 0; i < db.GetLength(0); i++)
        {
            if (db[i, 0].Equals(id_pw[0]) && db[i, 1].Equals(id_pw[1]))
            {
                answer = "login";
                break;
            }
            else if (db[i, 0].Equals(id_pw[0]) && !db[i, 1].Equals(id_pw[1]))
            {
                answer = "wrong pw";
                break;
            }
            else
            {
                answer = "fail";
            }
        }
        return answer;
    }
}
