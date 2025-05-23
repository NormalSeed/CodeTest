using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string letter) {
        Dictionary<string, char> morse = new Dictionary<string, char>
        {
            { ".-", 'a' }, { "-...", 'b' }, { "-.-.", 'c' }, { "-..", 'd' }, { ".", 'e' }, 
            { "..-.", 'f' }, { "--.", 'g' }, { "....", 'h' }, { "..", 'i' }, { ".---", 'j' },
            { "-.-", 'k' }, { ".-..", 'l' }, { "--", 'm' }, { "-.", 'n' }, { "---", 'o' }, 
            { ".--.", 'p' }, { "--.-", 'q' }, { ".-.", 'r' }, { "...", 's' }, { "-", 't' },
            { "..-", 'u' }, { "...-", 'v' }, { ".--", 'w' }, { "-..-", 'x' }, { "-.--", 'y' }, 
            { "--..", 'z' }
        };

        string []morseLetter = letter.Split(" ");
        string []morseLetterAns = new string[morseLetter.Length];
        for (int i = 0; i < morseLetter.Length; i++)
        {
            morseLetterAns[i] = morse[morseLetter[i]].ToString();
        }
        string answer = String.Join("", morseLetterAns);
        return answer;
    }
}