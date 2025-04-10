using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        //문자열을 공백 기준으로 잘라서 리스트에 넣고
        //리스트에서 하나씩 꺼내서 정수면 더하고 Z면 이전 순서의 정수를 빼준다
        List<string> sList = new List<string>(s.Split(' '));
        
        for (int i = 0; i < sList.Count; i ++)
        {
            if (int.TryParse(sList[i], out int num))
            {
                answer += num;
            }
            else if (sList[i] == "Z")
            {
                if (i > 0 && int.TryParse(sList[i - 1], out int prevNum))
                {
                    answer -= prevNum;
                }
            }
        }
        return answer;
    }
}