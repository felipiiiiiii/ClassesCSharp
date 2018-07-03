using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Character
{
    public uint getCharacteresPositionOfAlphabet (string a)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        foreach (char c in a.ToLower())
        {
            alphabet.IndexOf(c);
        }
    }
}

