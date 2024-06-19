using System.Collections.Generic;
using System;
public class Solution {
    public List<int> solution(int[] arr) {
       
        int min = arr[0];
        List<int> list = new List<int>();
       
        if(arr.Length == 1){
            list.Add(-1);
        }
        else
        {
            // 최소값 구하기
             for(int i = 0; i < arr.Length; i++)
             {
                 if (min > arr[i])
                 {
                     min = arr[i];
                 }
             }
           
           
            for(int i = 0; i < arr.Length; i++){
               
                if(arr[i] == min){
                    continue;
                } else{
                    list.Add(arr[i]);
                }  
            }
        }
       
       
        return list;
    }
}