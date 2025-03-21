using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int gcd;
        int a = numer1 * denom2 + numer2 * denom1;
        int b = denom1 * denom2;
        if (a >= b)
        {
            while (b != 0)
            {
                    int r = b;
                    b = a % b;
                    a = r;
            }
            gcd = a;
        }
        else
        {
            while (a != 0)
            {
                int r = a;
                a = b % a;
                b = r;
            }
            gcd = b;
        }
        int ansNum = (numer1 * denom2 + numer2 * denom1) / gcd;
        int ansDe = denom1 * denom2 / gcd;
        int[] answer = new int[] {ansNum, ansDe};
        return answer;
    }
}