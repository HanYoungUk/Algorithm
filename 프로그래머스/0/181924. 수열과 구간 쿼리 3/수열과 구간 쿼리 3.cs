using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int a = 0;
        int b = 0;

        for(int i = 0; i < queries.GetLength(0); i++)
        {
            a = queries[i, 0];
            b = queries[i, 1];
            int x = arr[a];
            int y = arr[b];

            arr[a] = y;
            arr[b] = x;
        }
        return arr;
    }
}