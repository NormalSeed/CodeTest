using System;

public class Solution {
    public double solution(int balls, int share) {
        // Factorial 계산 과정에서 큰 수를 다루게 되면 부동 소수점으로 처리됨.
        // 그러므로 Math.Round 메서드로 반올림을 해주어 해결한다.
        double answer = Math.Round(Combination(balls, share));
        
        return answer;
    }
    public double Combination(int n, int m)
    {
        return Factorial(n) / (Factorial(n - m) * Factorial(m));
    }
    public double Factorial(int n)
    {
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}