using System;
using System.Text;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 2;
        string[] compare = new string[str1.Length - str2.Length + 1];
        
        for (int i = 0; i < str1.Length - str2.Length + 1; i++)
        {
            StringBuilder sb = new StringBuilder();
            
            for (int j = 0; j < str2.Length; j++)
            {
                sb.Append(str1[i + j]);
            }
            
            compare[i] = sb.ToString();
        }
        
        for (int i = 0; i < compare.Length; i++)
        {
            if (compare[i] == str2)
            {
                answer = 1;
            }
        }
        
        return answer;
    }
}