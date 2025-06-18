using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        char[] chars = s.ToCharArray();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLower(s[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
            }
            else
            {
                chars[i] = char.ToLower(chars[i]);
            }
        }
        string answer = new string(chars);
        
        Console.WriteLine(answer);
    }
}