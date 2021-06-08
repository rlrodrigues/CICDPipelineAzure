using System;
using Xunit;

namespace Example.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a = 0;
            var b = 0;
            var c = 1;

            Assert.Equal(a, b);
        }
    }
}
