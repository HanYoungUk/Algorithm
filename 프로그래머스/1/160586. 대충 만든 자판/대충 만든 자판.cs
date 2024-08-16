using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        int sum = 0;

        for (int i = 0; i < targets.Length; i++)
        {
            for (int j = 0; j < targets[i].Length; j++) // target요소들의 각 문자들 확인 for문
            {
                List<int> list = new List<int>();

                for (int k = 0; k < keymap.Length; k++)
                {
                    int x = keymap[k].IndexOf(targets[i][j]);

                    list.Add(x);
                }

                list.Sort();

                if(list.Count == 1)
                {
                    if (list[0] == -1)
                    {
                        sum = -1;
                        break;
                    }
                    sum += list[0] + 1;
                    continue;
                }

                int minus = list.Count(n => n == -1);

                if(list.Count == minus)
                {
                    sum = -1;
                    break;
                }

                if (list[0] == -1)
                {
                    foreach(var n in list)
                    {
                        if(n != -1)
                        {
                            sum += n + 1;
                            break;
                        }
                    }
                }
                else
                {
                    sum += list[0] + 1;
                }
            }
            answer[i] = sum;
            sum = 0;
        }
        return answer;
    }
}