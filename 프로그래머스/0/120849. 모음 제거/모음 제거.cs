using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        Queue<char> ansQue = new Queue<char>();
        
        for (int i = 0; i < my_string.Length; i++)
        {
            //모음이 아니면 결과 큐에 집어넣고 모음이면 통과;
            if(my_string[i] == 'a' || my_string[i] == 'e' || my_string[i] == 'i' || my_string[i] == 'o' || my_string[i] == 'u')
                continue;

            else
            {
                //순서대로 넣을 것이다;
                ansQue.Enqueue(my_string[i]);
            }
        }
        StringBuilder result = new StringBuilder();
        while (ansQue.Count > 0)
        {
            result.Append(ansQue.Dequeue());
        }
        string answer = result.ToString();
        return answer;
    }
}