using System;

public class Solution {
    public double solution(int balls, int share) {
        // Combination  
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