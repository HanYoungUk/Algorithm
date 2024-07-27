using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
public class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;
        int count = 0;
        int num2 = 0;
        List<int> list = new List<int>() { a, b, c, d };
        int num = 0;
        for(int i = 0; i < list.Count; i++)
        {
            for(int j = i + 1; j < list.Count; j++)
            {
                if (list[i] == list[j])
                {
                    num = list[i];
                    count++;
                }
            }
        }
        List<int> list2 = new List<int>();
        switch (count)
        {
            case 0:
                answer = list.Min();
                    break;
            case 1:
                foreach(int i in list)
                {
                    if (num != i)
                        list2.Add(i);
                }
                answer = list2[0] * list2[1];
                    break;
            case 2:
                int x = list.Max();
                int y = list.Min();
                answer = (x + y) * Math.Abs(x - y);
                break;
            case 3:
                foreach (int i in list)
                {
                    if (num != i)
                    {
                    num2 = i;
                    break;
                    }
                }
                answer = (10 * num + num2) * (10 * num + num2);
                    break;
            case 6:
                answer = num * 1111;
                    break;
        }
        return answer;
    }
}