using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        
        List<char> strToChar = new List<char>();
        foreach(char c in my_string)
        {
            strToChar.Add(c);
        }
        
        char temp;
        temp = strToChar[num1];
        strToChar[num1] = strToChar[num2];
        strToChar[num2] = temp;
        
        StringBuilder result = new StringBuilder();
        foreach(char c in strToChar)
        {
            result.Append(c);
        }
        
        answer = result.ToString();
        return answer;
    }
}