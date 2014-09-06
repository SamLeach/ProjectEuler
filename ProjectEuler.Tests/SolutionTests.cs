using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class SolutionTests : TestTimer
    {
        private ISolutions solutions;

        [TestCase(1000, 233168)]
        public void Solution1(int n, int ans)
        {
            var answer = solutions.Problem1(n);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(4000000, 4613732)]
        public void Solution2(int n, int ans)
        {
            var answer = solutions.Problem2(n);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(600851475143, 6857)]
        public void Solution3(decimal n, decimal ans)
        {
            var answer = solutions.Problem3(n);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(906609, 999)]
        public void Solution4(int n, int ans)
        {
            var answer = solutions.Problem4(n);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(232792560)]
        public void Solution5(decimal n, decimal ans)
        {
            var answer = solutions.Problem5(n);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(25164150, 100)]
        public void Solution6(double n, double ans)
        {
            var answer = solutions.Problem6(n);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(104743, (ulong)10001)]
        public void Solution7(ulong n, ulong ans)
        {
            var answer = solutions.Problem7(n);
            Assert.AreEqual(ans, answer);
        }

        [TestCase((ulong)23514624000, 13)]
        public void Solution8(int n, int ans)
        {
            var answer = solutions.Problem8(n);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(1000, 31875000)]
        public void Solution9(int n, int ans)
        {
            var answer = solutions.Problem9(n);
            Assert.AreEqual(ans, answer);
        }

        [TestCase((ulong)142913828922, (ulong)2000000)]
        public void Solution10(ulong n, ulong ans)
        {
            var answer = solutions.Problem10(n);
            Assert.AreEqual(ans, answer);
        }

        [SetUp]
        public override void SetUp()
        {
            // call base setup explicitly
            base.SetUp();
            solutions = new NaiveSolutions();
        }
    }
}
