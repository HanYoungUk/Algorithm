using System;
using System.Linq;

public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        int[] arr2 = (int[])arr.Clone();
        while (true)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 50 && arr[i] % 2 == 0)
                {
                    arr[i] = arr[i] / 2;
                }
                else if (arr[i] < 50 && arr[i] % 2 == 1)
                {
                    arr[i] = arr[i] * 2 + 1;
                }
            }
            if(Enumerable.SequenceEqual(arr, arr2) == true)
            {
                break;
            }
            arr2 = (int[])arr.Clone();
            answer++;
        }
        return answer;
    }
}