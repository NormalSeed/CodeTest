using System;

public class Solution {
    public string solution(string my_string, int n) {
        char[] ansArr = my_string.ToCharArray();
        string answer = "";
        for ( int i = 0; i < ansArr.Length; i++)
        {
            int j = 0;
            while (j < n)
            {
                answer += ansArr[i];
                j++;
            }
        }
        return answer;
    }
}