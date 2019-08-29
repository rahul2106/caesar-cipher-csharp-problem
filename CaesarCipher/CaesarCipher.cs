using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {private static char Cipher(char ch, int key)
{
	if (!char.IsLetter(ch))
		return ch;

	char offset = char.IsUpper(ch) ? 'A' : 'a';
	return (char)((((ch + key) - offset) % 26) + offset);
}
        
        public static string Rotate(string text, int shiftKey)
        {
          string output = string.Empty;

	foreach (char ch in text)
		output += Cipher(ch, shiftKey);

	return output;
        }
        public static void Main(string[] args){
            
        }
    }
}
