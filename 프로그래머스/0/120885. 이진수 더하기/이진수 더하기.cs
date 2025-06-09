using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = "";
        int dec1 = Convert.ToInt32(bin1, 2);
        int dec2 = Convert.ToInt32(bin2, 2);
        int sum = dec1 + dec2;
        
        answer = Convert.ToString(sum, 2);
        return answer;
    }
}