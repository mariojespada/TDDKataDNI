using System;
using TDDKataDNI;
using Xunit;

namespace TDDKatDniTest
{
    public class DNIShould
    {
        [Theory]
        [InlineData ("1234567890R")]
        [InlineData("12345678R")]
        public void Have_no_other_than_10_digits(string dniNumber)
        {
            Assert.Throws<ArgumentException>(() => new Dni(dniNumber));
        }

        [Fact]
        public void Have_10_digits()
        {
            var dni = new Dni("123456789R");
            Assert.NotNull(dni);
        }

        [Fact]
        public void First_9_must_be_numbers()
        {
            Assert.Throws<ArgumentException>(() => new Dni("12345678R9"));
        }

        [Fact]
        public void Last_must_be_letter()
        {
            Assert.Throws<ArgumentException>(() => new Dni("1234567890"));
        }

        [Theory]
        [InlineData("123456789Ñ")]
        [InlineData("123456789U")]
        [InlineData("123456789O")]
        [InlineData("123456789I")]
        [InlineData("123456789i")]
        public void Is_valid_letter(string dniNumber)
        {
            Assert.Throws<ArgumentException>(() => new Dni(dniNumber));
        }

        [Fact]
        public void ShouldNotBeOtherThanT()
        {
            Assert.Throws<ArgumentException>(() => new Dni("000000023H"));
        }
    }
}
