using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        List<int> list = score.ToList();
        int num = 0;
        int remain = 0;

        while (k > 0)
        {
            num = list.Count(n => n == k); // k의 개수를 구함
            int count = num / m; // 상자의 개수
            remain += num % m; // 남은 사과의 개수
            if(remain >= m)
            {
                remain = remain - m;
                answer += k * 1 * m;
            }
            answer += count * k * m;
            list.RemoveAll(n => n == k); // k를 전부다 제거
            k--; // k를 1씩 감소
        }
        return answer;
    }
}