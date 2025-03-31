using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers, int k) {
        Queue<int> que = new Queue<int>(numbers.Length);
        for (int i = 0; i < numbers.Length; i++)
        {
            que.Enqueue(numbers[i]);
        }
        while (k > 1)
        {
            int num1 = que.Peek();
            que.Dequeue();
            que.Enqueue(num1);
            int num2 = que.Peek();
            que.Dequeue();
            que.Enqueue(num2);
            k--;
        }
        int answer = que.Peek();
        return answer;
    }
}