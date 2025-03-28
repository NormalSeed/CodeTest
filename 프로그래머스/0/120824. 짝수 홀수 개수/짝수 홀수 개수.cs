using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int odd = 0;
        int even = 0;
        for ( int i = 0; i < num_list.Length; i++)
        {
            if (num_list[i] % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }
        int[] answer = new int[2] {even, odd};
        return answer;
    }
}