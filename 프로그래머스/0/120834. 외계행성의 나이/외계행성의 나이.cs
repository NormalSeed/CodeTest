using System;

public class Solution {
    public string solution(int age) {
        string ageStr = age.ToString();
        string[] alphToNum = new string[10]{
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" 
        };
        int[] ageArr = new int[ageStr.Length];
        for (int i = 0; i < ageArr.Length; i++)
        {
            ageArr[i] = int.Parse(ageStr[i].ToString());
        }
        string answer = "";
        string[] ansStr = new string[ageArr.Length];
        for (int i = 0; i < ageArr.Length; i++)
        {
            ansStr[i] = alphToNum[ageArr[i]];
        }
        foreach (string alphabet in ansStr)
        {
            answer += alphabet;
        }
        return answer;
    }
}