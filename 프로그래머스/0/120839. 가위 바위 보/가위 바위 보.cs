using System;

public class Solution {
    public string solution(string rsp)
    {
        string[] rspStr = new string[rsp.Length];
        for (int i = 0; i < rsp.Length; i++)
        {
            rspStr[i] = rsp[i].ToString();
        }
    
        string[] result = new string[rspStr.Length];
        for (int i = 0; i < rspStr.Length; i++)
        {
            if (rspStr[i] == "0")
            {
                result[i] = "5";
            }
            else if (rspStr[i] == "2")
            {
                result[i] = "0";
            }
            else if (rspStr[i] == "5")
            {
                result[i] = "2";
            }
        }
    
        string answer = String.Join("", result);
        return answer;
    }
//    다른 사람 풀이 : 람다식과 Concat으로 구현, 람다식 연습하자
//    public class Solution
//    {
//        public string solution(string rsp)
//        {
//            string answer = String.Concat(rsp.Select(x => x == '2' ? '0' : x == '0' ? '5' : '2'));
//            return answer;
//        }
//    }
}