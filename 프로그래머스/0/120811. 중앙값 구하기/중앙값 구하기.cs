using System;

public class Solution {
    public int solution(int[] array) {
        Array.Sort(array);
        int middlePoint = array.Length / 2;
        
        int answer = array[middlePoint];
        return answer;
    }
}