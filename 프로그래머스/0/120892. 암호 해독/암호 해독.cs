using System;
using System.Text;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        
        StringBuilder result = new StringBuilder();
        
        int targetIndex = code - 1;
        
        while (targetIndex < cipher.Length)
        {
            result.Append(cipher[targetIndex]);
            targetIndex += code;
        }
        
        answer = result.ToString();
        
        return answer;
    }
}