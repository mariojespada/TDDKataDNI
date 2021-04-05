using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDKataDNI
{
    public enum CorrectLetters 
    {
        T
    }

    public record DNILetter
    {
        public readonly char[] invalidLetters = new char[] { 'U', 'I', 'O', 'Ñ' };

        public DNILetter(char letter)
        {
            EnsureLastCharacterIsALetter(letter);
            EnsureLetterIsCorrect(letter);
        }

        private void EnsureLetterIsCorrect(char letter)
        {            
            var upperCaseLetter = char.ToUpper(letter);
            if (invalidLetters.Contains(upperCaseLetter))
            {
                throw new ArgumentException();
            }
        }

        private void EnsureLastCharacterIsALetter(char letter)
        {
            if (!char.IsLetter(letter))
            {
                throw new ArgumentException();
            }
        }
    }
}
