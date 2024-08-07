public class Solution {
    public int solution(int[] arr) {
       
        int x = arr[0]; // 첫번째 수를 x에 저장
        int max = 0; // 최대공약수
        int min = 0; // 최소공배수

        for (int i = 1; i < arr.Length; i++)
        {
            for(int j = 1; j <= arr[i]; j++)
            {
                if(x % j == 0 && arr[i] % j == 0)
                {
                    max = j;
                }
            }
            min = (x / max) * (arr[i] / max) * max;

            x = min;
        }
       
        return min;
    }
}