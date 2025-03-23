using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        int maxArray = 0;
        int maxAns = 0;
        for ( int i = 0; i < array.Length; i++)
        {
            if ( maxArray < array[i])
            {
                maxArray = array[i];
            }
        }
        int[] countArray = new int[maxArray + 1];
        
        for ( int i = 0; i < array.Length; i++)
        {
            countArray[array[i]]++;
        }
        for ( int i = 0; i < countArray.Length; i++)
        {
            if (maxAns < countArray[i])
            {
                maxAns = countArray[i];
                answer = i;
            }
        }
        for ( int i = 0; i < countArray.Length; i++)
        {
            if ( i != answer && countArray[i] == maxAns)
            {
                answer = -1;
            }
        }
        return answer;
    }
}