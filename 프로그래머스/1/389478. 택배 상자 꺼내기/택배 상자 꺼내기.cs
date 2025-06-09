using System;

public class Solution {
    public int solution(int n, int w, int num) {
        int answer = 0;
        // 층의 갯수 row
        int row = 0;
        if (n % w == 0) row = n / w;
        else row = n / w + 1;
        
        // 쌓인 택배 상자의 2차원 배열
        int[,] boxes = new int[row, w];
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0 ; j < w; j++)
            {
                if (i % 2 == 0)
                {
                    if (i * w + j + 1 > n)
                    {
                        boxes [i, j] = 0;
                    }
                    else
                    {
                        boxes[i, j] = i * w + j + 1;    
                    }
                }
                else
                {
                    if (i * w + w - j > n)
                    {
                        boxes[i, j] = 0;
                    }
                    else
                    {
                        boxes[i, j] = i * w + w - j;    
                    }
                }
            }
        }
        
        // 상자 번호를 boxes에서 몇 행인지 탐색
        
        int ansRow = -1;
        int ansCol = -1;
        
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < w; j++)
            {
                if (boxes[i, j] == num)
                {
                    ansRow = i;
                    ansCol = j;
                }
            }
        }
        
        if (boxes[row - 1, ansCol] == 0) // 만약 boxes[row, ansCol]에 값이 없다면
        {
            answer = row - ansRow - 1;
        }
        else
        {
            answer = row - ansRow;
        }
        
        return answer;
    }
}