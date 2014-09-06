using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class HelperTests : TestTimer
    {
        [TestCase((ulong)1, false)]
        [TestCase((ulong)7, true)]
        [TestCase((ulong)8, false)]
        [TestCase((ulong)11, true)]
        [TestCase((ulong)13, true)]
        [TestCase((ulong)997, true)]
        [TestCase((ulong)998, false)]
        public void IsPrime(ulong num, bool ans)
        {
            var answer = Helper.IsPrime(num);
            Assert.AreEqual(ans, answer);
        }

        [TestCase((ulong)1, false)]
        [TestCase((ulong)7, true)]
        [TestCase((ulong)8, false)]
        [TestCase((ulong)11, true)]
        [TestCase((ulong)13, true)]
        [TestCase((ulong)997, true)]
        [TestCase((ulong)998, false)]
        public void IsPrimeDotNetPearls(ulong num, bool ans)
        {
            var answer = Helper.DotNetPerlsIsPrime(num);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(9009, true)]
        [TestCase(9010, false)]
        public void IsPalindrome(long num, bool ans)
        {
            var answer = Helper.IsPalindromeToString(num);
            Assert.AreEqual(ans, answer);
        }
    }
}
