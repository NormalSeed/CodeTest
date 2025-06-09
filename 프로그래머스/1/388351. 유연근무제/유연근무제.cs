using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        bool isRewarded = false;
        // 출근 희망 시간 + 10분인 정수 배열 timeLimit[]
        int[] timeLimit = new int[schedules.Length];
        for (int i = 0; i < schedules.Length; i++)
        {
            timeLimit[i] = schedules[i] + 10;
            // 분 단위가 60 이상이면 시간 +1
            if (timeLimit[i] % 100 >= 60)
            {
                timeLimit[i] += 40;
            }
        }
        
        for (int i = 0; i < timelogs.GetLength(0); i++)
        {
            for (int j = 0; j < timelogs.GetLength(1); j++)
            {
                if (timelogs[i, j] <= timeLimit[i] ||
                        (j + startday) % 7 == 6 || (j + startday) % 7 == 0)
                {
                    isRewarded = true;
                }
                else
                {
                    isRewarded = false;
                    break;
                }
            }
            if (isRewarded)
            {
                answer++;
            }
            isRewarded = false;
        }
        
        return answer;
    }
}