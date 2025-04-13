using System;

public class Solution {
    public string[] solution(string[] quiz) {
        string[] answer = new string[quiz.Length];
        
        for (int i = 0; i < quiz.Length; i++)
        {
            string[] calc = new string[5];
            int result = 0;
            calc = quiz[i].Split(' ');
            if (calc[1] == "+")
            {
                result = int.Parse(calc[0]) + int.Parse(calc[2]);
            }
            else if (calc[1] == "-")
            {
                result = int.Parse(calc[0]) - int.Parse(calc[2]);
            }
            
            if (result == int.Parse(calc[4]))
            {
                answer[i] = "O";
            }
            else
            {
                answer[i] = "X";
            }
        }
        
        return answer;
    }
}