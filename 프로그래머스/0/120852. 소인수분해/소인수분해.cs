using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
    List<int> primeFactors = new List<int>();

    for (int i = 2; i <= n; i++)
    {
        while (n % i == 0)
        {
            n /= i;
            if (!primeFactors.Contains(i))
            {
                primeFactors.Add(i);
            }
        }
    }


    int[] answer = primeFactors.ToArray();
    return answer;
        }
    }