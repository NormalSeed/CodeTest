using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        Queue<int> queue = new Queue<int>(numbers.Length);
        for (int i = 0; i < numbers.Length; i++)
            {
                queue.Enqueue(numbers[i]);
            }
        
        Stack<int> stack = new Stack<int>(numbers.Length);
        for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }
        
        int[] answer = new int[numbers.Length];
        
        if (direction == "right")
        {
            int popValue = stack.Pop();
            answer[0] = popValue;
            for (int i = 1; i < numbers.Length; i++)
            {
                answer[i] = queue.Dequeue();
            }
            
        }
        else if (direction == "left")
        {
            int value = queue.Dequeue();
            queue.Enqueue(value);
            for (int i = 0; i < numbers.Length; i++)
            {
                answer[i] = queue.Dequeue();
            }
        }
        return answer;
    }
}