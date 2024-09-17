import java.util.*;

public class Solution {
    public ArrayList<Integer> solution(int []arr) {
       Stack<Integer> stack = new Stack<>();
        ArrayList<Integer> list = new ArrayList<>();
       
        for(int i = arr.length - 1; i >= 0; i--)
        {
            stack.push(arr[i]);
        }
        int x = -1;
       
        for(int i = 0; i < arr.length; i++)
        {
           
            int num = stack.pop();
            if(num == x) // 같을 경우 넘어감
            {
                continue;
            }
            else
            {
                list.add(num);
            }
           
            x = num;
        }
       
        return list;
    }
}