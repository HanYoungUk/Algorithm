using System;

public class Solution {
    public int[] solution(int n, int k) {
        int[] arr = new int[n / k];

        int count = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = count++ * k;
        }
       
       
        return arr;
    }
}