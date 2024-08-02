using System;

public class Solution {
    public string solution(int a, int b) {
        string[] day = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

        // date 설정
        DateTime date = new DateTime(2016, a, b);

        // 날짜의 요일 가져오기
        DayOfWeek dayOfWeek = date.DayOfWeek;

        // 날짜의 숫자 가져오기
        int index = (int)dayOfWeek;
        string answer = day[index];
           
        return answer;
    }
}