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

//다른사람 풀이
//using System;

//public class Solution
//{
//    public string solution(string my_string)
//    {
//        string answer = "";
//        string[] b = new string[] { "a", "e", "i", "o", "u" };

//        foreach (string c in b)
//        {
//            my_string = my_string.Replace(c, "");
//        }
//        return my_string;
//    }
//}