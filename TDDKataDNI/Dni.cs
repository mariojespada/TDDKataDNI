using System;

namespace TDDKataDNI
{
    public record Dni
    {
        public Dni(string dniNumber)
        {
            throw new ArgumentException();
        }
    }
}
