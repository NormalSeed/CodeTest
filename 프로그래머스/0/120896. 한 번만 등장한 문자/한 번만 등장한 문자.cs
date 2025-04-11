using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        List<char> onlyChar = new List<char>();
        foreach(char c in s)
        {
            if (!onlyChar.Contains(c))
            {
                onlyChar.Add(c);
            }
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    if(onlyChar.Contains(s[i]))
                    {
                        onlyChar.Remove(s[i]);
                        break;
                    }
                }
            }
        }
        onlyChar.Sort();
        
        StringBuilder result = new StringBuilder();
        foreach (char c in onlyChar)
        {
            result.Append(c);
        }
        
        answer = result.ToString();
        
        return answer;
    }
}