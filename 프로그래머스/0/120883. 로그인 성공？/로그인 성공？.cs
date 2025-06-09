using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "";
        
        Dictionary<string, string> dic = new Dictionary<string, string>();
        
        for (int i = 0; i < db.GetLength(0); i++)
        {
            dic[db[i, 0]] = db[i, 1];
        }
        
        if (dic.ContainsKey(id_pw[0]) && dic[id_pw[0]] == id_pw[1])
        {
            answer = "login";
        }
        else if(!dic.ContainsKey(id_pw[0]))
        {
            answer = "fail";
        }
        else if(dic.ContainsKey(id_pw[0]) && dic[id_pw[0]] != id_pw[1])
        {
            answer = "wrong pw";
        }
        
        return answer;
    }
}