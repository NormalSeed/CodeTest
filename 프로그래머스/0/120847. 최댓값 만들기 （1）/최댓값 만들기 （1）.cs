using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int maxNumber = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maxNumber)
            {
                maxNumber = num;
            }
        }
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] == maxNumber)
            {
                numbers[i] = 0;
                break;
            }
        }
        
        int maxNumber2 = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maxNumber2)
            {
                maxNumber2 = num;
            }
        }
        
        answer = maxNumber * maxNumber2;
        return answer;
    }
}