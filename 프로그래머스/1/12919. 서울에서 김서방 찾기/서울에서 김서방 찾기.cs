public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int count = 0;
        for(int i = 0; i < seoul.Length; i++){
            if(seoul[i].Equals("Kim")){
                answer = $"김서방은 {i}에 있다";
            }
        }
        return answer;
    }
}