using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        List<int> numStr = new List<int>();
        foreach(char c in my_string)
        {
            if(char.IsDigit(c))
            {
                numStr.Add(c - '0');
            }
        }
        int listSize = numStr.Count;
        for (int i = 0; i < listSize; i++)
        {
            for (int j = i; j < listSize; j++)
            {
                if (numStr[i] > numStr[j])
                {
                    int temp = numStr[i];
                    numStr[i] = numStr[j];
                    numStr[j] = temp;
                }
            }
        }
        
        int[] answer = new int[numStr.Count];
        
        for (int i = 0; i < numStr.Count; i++)
        {
            answer[i] = numStr[i];
        }
        return answer;
    }
}
// 다른사람 풀이 추가
// LINQ 사용
// using System;
// using System.Linq;

// public class Solution {
//     public int[] solution(string my_string) {
//             my_string = System.Text.RegularExpressions.Regex.Replace(my_string, "[^0-9]", "");
//             int[] answer = my_string.Select(x => int.Parse(x.ToString())).ToArray();
//             Array.Sort(answer);
//             return answer;
//     }
// }