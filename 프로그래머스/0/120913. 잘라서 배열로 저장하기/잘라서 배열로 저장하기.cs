using System;
using System.Text;

public class Solution {
    public string[] solution(string my_str, int n) {
        int count = 0;
        if (my_str.Length % n == 0)
        {
            count = my_str.Length / n;
        }
        else
        {
            count = my_str.Length / n + 1;
        }
        string[] answer = new string[count];
        StringBuilder word = new StringBuilder();
        int temp = n;
        for (int i = 0; i < my_str.Length; i++)
        {
            word.Append(my_str[i]);
            temp -= 1;
            if (temp == 0)
            {
                answer[i / n] = word.ToString();
                word = new StringBuilder();
                temp = n;
            }
        }
        
        if (word.ToString().Length > 0)
        {
            answer[answer.Length - 1] = word.ToString();
        }
        
        return answer;
    }
}