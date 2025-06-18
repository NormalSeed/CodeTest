using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        string answer = "";
        
        // 길이를 나타내는 4가지 변수를 초단위로 통일해줘야 함
        int video_len_sec = minToSec(video_len);
        int pos_sec = minToSec(pos);
        int op_start_sec = minToSec(op_start);
        int op_end_sec = minToSec(op_end);
        
        if (op_start_sec <= pos_sec && pos_sec <= op_end_sec)
        {
            pos_sec = op_end_sec;
        }
        
        for (int i = 0; i < commands.Length; i++)
        {
            if (commands[i] == "prev")
            {
                if (pos_sec >= 10)
                {
                    pos_sec -= 10;
                    if (op_start_sec <= pos_sec && pos_sec <= op_end_sec)
                    {
                        pos_sec = op_end_sec;
                    }
                }
                else
                {
                    pos_sec = 0;
                    if (op_start_sec <= pos_sec && pos_sec <= op_end_sec)
                    {
                        pos_sec = op_end_sec;
                    }
                }
            }
            else if (commands[i] == "next")
            {
                if (pos_sec >= video_len_sec - 10)
                {
                    pos_sec = video_len_sec;
                    if (op_start_sec <= pos_sec && pos_sec <= op_end_sec)
                    {
                        pos_sec = op_end_sec;
                    }
                }
                else
                {
                    pos_sec += 10;
                    if (op_start_sec <= pos_sec && pos_sec <= op_end_sec)
                    {
                        pos_sec = op_end_sec;
                    }
                }
            }
        }
        
        int[] resultArr = new int[2];
        resultArr[0] = pos_sec / 60;
        resultArr[1] = pos_sec % 60;
        
        answer = intToString(resultArr);
        
        return answer;
    }
    
    public int minToSec(string len)
    {
        string[] minAndSec = len.Split(":");
        int [] minAndSecInt = new int[2];
        for (int i = 0; i < 2; i++)
        {
            minAndSecInt[i] = int.Parse(minAndSec[i]);
        }
        
        int result = minAndSecInt[0] * 60 + minAndSecInt[1];
        return result;
    }
    
    public string intToString(int[] pos)
    {
        string min;
        string sec;
        
        if (pos[0] < 10)
        {
            min = "0" + pos[0].ToString();    
        }
        else
        {
            min = pos[0].ToString();
        }
        
        if (pos[1] < 10)
        {
            sec = "0" + pos[1].ToString();
        }
        else
        {
            sec = pos[1].ToString();
        }
        
        string result = min + ":" + sec;
        return result;
    }
}