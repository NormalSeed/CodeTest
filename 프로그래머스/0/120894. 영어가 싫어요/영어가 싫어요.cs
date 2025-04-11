using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        // Key를 영어숫자, Value를 수로 가지는 Dictionary를 만든다
        // 수를 담을 int형식 리스트 result를 만든다
        // numbers에서 한글자씩 받아서 StringBuilder로 문자열을 만들어 나가다가
        // Dictionary 안에 해당 StringBuilder의 문자열이 Key로써 존재하면
        // result에 해당 Key에 해당하는 value값을 저장한다.
        // 마지막으로 해당 배열을 자릿수에 맞춰 answer에 담는다.
        
        Dictionary<string, int> digitDic = new Dictionary<string, int>
        {
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
            {"zero", 0}
        };
        
        List<int> result = new List<int>();
        StringBuilder engNum = new StringBuilder();
        for (int i = 0; i < numbers.Length; i++)
        {
            engNum.Append(numbers[i]);
            if(digitDic.ContainsKey(engNum.ToString()))
            {
                result.Add(digitDic[engNum.ToString()]);
                engNum.Clear();
            }
        }
        
        long digit = 1;
        for (int i = result.Count - 1; i >= 0; i--)
        {
            answer += result[i] * digit;
            digit *= 10;
        }
        return answer;
    }
}