using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {
        strings = strings.OrderBy(x => x).OrderBy(x => x[n]).ToArray();
       
        return strings;
    }
}