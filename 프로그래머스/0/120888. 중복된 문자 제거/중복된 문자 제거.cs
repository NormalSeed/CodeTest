using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        HashSet<char> strHash = new HashSet<char>();
        StringBuilder result = new StringBuilder();
        
        foreach(char c in my_string)
        {
            if (!strHash.Contains(c))
            {
                strHash.Add(c);
                result.Append(c);
            }
        }
        
        string answer = result.ToString();
        return answer;
    }
}