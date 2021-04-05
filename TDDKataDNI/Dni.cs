using System;
using System.Collections.Generic;
using System.Linq;

namespace TDDKataDNI
{
    public record Dni
    {
        public readonly char[] invalidLetters = new char[] { 'U', 'I', 'O', 'Ñ' };

        public Dni(string dniNumber)
        {
            EnsureDNIIsTenCharactersLong(dniNumber);            
            EnsureLastCharacterIsALetter(dniNumber);
            EnsureLetterIsCorrect(dniNumber);
            EnsureFirstNineCharactersAreNumbers(dniNumber);
        }

        private void EnsureLetterIsCorrect(string dniNumber)
        {
            var lastCharacter = dniNumber.Last();
            var upperCaseLetter = char.ToUpper(lastCharacter);
            if (invalidLetters.Contains(upperCaseLetter))
            {
                throw new ArgumentException();
            }
        }

        private void EnsureFirstNineCharactersAreNumbers(string dniNumber)
        {
            var dniNumberPart = dniNumber.Take(9);

            if (!dniNumberPart.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException();
            }
        }

        private void EnsureDNIIsTenCharactersLong(string dniNumber)
        {
            if (dniNumber.Length != 10)
            {
                throw new ArgumentException();
            }
        }
               
        private void EnsureLastCharacterIsALetter(string dniNumber)
        {
            var lastCharacter = dniNumber.Last();
            if(!char.IsLetter(lastCharacter))
            {
                throw new ArgumentException();
            }
        }
    }
}
