using System;
using System.Text;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        string[] elements = polynomial.Split(' ');
        int xSum = 0;
        int numSum = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            if (elements[i].EndsWith("x"))
            {
                if (elements[i].Length > 1)
                {
                    string count = elements[i].Substring(0, elements[i].Length - 1);
                    xSum += string.IsNullOrEmpty(count) ? 1 : int.Parse(count);
                }
                else
                {
                    xSum ++;
                }
            }
            else if (elements[i] != "+")
            {
                numSum += int.Parse(elements[i]);
            }
        }
        
        StringBuilder result = new StringBuilder();
        
        if (xSum == 0 && numSum != 0)
        {
            answer = numSum.ToString();
        }
        else if (numSum == 0 && xSum != 0)
        {
            if (xSum == 1)
            {
                answer = "x";
            }
            else
            {
                result.Append(xSum);
                result.Append('x');
                answer = result.ToString();   
            }
        }
        else if (xSum != 0 && numSum != 0)
        {
            if (xSum == 1)
            {
                result.Append("x + ");
                result.Append(numSum);
                
                answer = result.ToString();
            }
            else
            {
                result.Append(xSum);
                result.Append("x + ");
                result.Append(numSum);
            
                answer = result.ToString();   
            }
        }
        
        return answer;
    }
}