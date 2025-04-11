using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        
        Array.Sort(array);
        
        int[] absArray = new int[array.Length];
        
        for (int i = 0; i < array.Length; i++)
        {
            absArray[i] = Math.Abs(array[i] - n);
        }
        
        int minAbs = Int32.MaxValue;
        for (int i = 0; i < absArray.Length; i++)
        {
            if (minAbs > absArray[i])
            {
                minAbs = absArray[i];
            }
        }
        
        int targetIndex = Array.IndexOf(absArray, minAbs);
        answer = array[targetIndex];
        
        return answer;
    }
}