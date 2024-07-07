using System;

public class Solution {
    public int[] solution(int[] arr) {
       
       
         // 2의 거듭제곱으로 만들기
         int count = 1;
         for(int i = 1; i <= 10; i++)
         {
             
             if (count > arr.Length)
             {
                 break;
             }
             if(count == arr.Length)
             {

                 break;
             }
             count *= 2;
         }

         int[] answer = new int[count];

         for(int i = 0; i < arr.Length; i++)
         {
             answer[i] = arr[i];
         }
        return answer;
    }
}
