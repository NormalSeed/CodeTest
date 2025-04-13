using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        char[] lowers = new char[my_string.Length];
        for (int i = 0; i < my_string.Length; i++)
        {
            if (char.IsUpper(my_string[i]))
            {
                lowers[i] = char.ToLower(my_string[i]);
            }
            else
            {
                lowers[i] = my_string[i];
            }
        }
        Array.Sort(lowers);
        
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < lowers.Length; i++)
        {
            result.Append(lowers[i]);
        }
        answer = result.ToString();
        return answer;
    }
}