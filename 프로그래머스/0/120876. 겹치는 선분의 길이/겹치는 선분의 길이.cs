using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[,] lines) {
    Dictionary<int, int> segments = new Dictionary<int, int>();

    int rowCount = lines.GetLength(0); // 2차원 배열의 행 개수

    // 선분의 모든 위치를 기록
    for (int i = 0; i < rowCount; i++)
    {
        int start = lines[i, 0]; // 시작점
        int end = lines[i, 1];   // 끝점

        for (int j = start; j < end; j++) // 끝점을 포함하지 않음
        {
            if (!segments.ContainsKey(j))
                segments[j] = 0;
            segments[j]++;
        }
    }

    // 두 개 이상의 선분이 겹친 부분 계산
    int overlapLength = 0;
    foreach (var entry in segments)
    {
        if (entry.Value >= 2) // 두 개 이상 겹친 경우
            overlapLength++;
    }

    return overlapLength;
    }
}