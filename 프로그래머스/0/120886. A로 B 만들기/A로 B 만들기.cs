using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        char[] beforeArr = new char[before.Length];
        char[] afterArr = new char[after.Length];
        for (int i = 0; i < before.Length; i++)
        {
            beforeArr[i] = before[i];
            afterArr[i] = after[i];
        }
        Array.Sort(beforeArr);
        Array.Sort(afterArr);
        
        for (int i = 0; i < beforeArr.Length; i++)
        {
            if (beforeArr[i] == afterArr[i])
            {
                answer = 1;
            }
            else
            {
                answer = 0;
                break;
            }
        }
        
        return answer;
    }
}