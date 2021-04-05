using System;
using TDDKataDNI;
using Xunit;

namespace TDDKatDniTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Throws<ArgumentException>(() => new Dni("1234567890R"));
        }
    }
}
