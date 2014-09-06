﻿using NUnit.Framework;

namespace ProjectEuler.Tests
{
    [TestFixture]
    public class ProblemTests : TestTimer
    {
        [TestCase(10, 23)]
        [TestCase(1000, 233168)]
        public void Multiplesof3And5(int num, int ans)
        {
            int answer = Problems.Multiplesof3And5(num);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(4000000, 4613732)]
        public void EvenFibonacciNumbers(int num, int ans)
        {
            var answer = Problems.Fibanacci(Helper.IsEven, num);
            Assert.AreEqual(ans, answer);
        }

        [TestCase((ulong)13195, 29)]
        [TestCase((ulong)600851475143, 6857)]
        [Ignore("Too slow to finish")]
        public void LargestPrimeFactor(ulong num, long ans)
        {
            var answer = Problems.LargestPrimeFactor(Helper.DotNetPerlsIsPrime, num);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(13195, 29)]
        [TestCase(600851475143, 6857)]
        [Category("Slow Running")]
        public void PacoLargestPrimeFactor(long num, long ans)
        {
            var answer = Problems.PacoLargestPrimeFactor(Helper.IsInteger, Helper.IsPrime, num);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(906609, 999)]
        [TestCase(9009, 99)]
        public void Problem4(int ans, int digits)
        {
            var answer = Problems.LargestPalindromeFromProductOfTwoDigitNumbers(Helper.IsPalindromeToString, digits);
            Assert.AreEqual(ans, answer);
        }

        [Test]
        public void SmallestMultipleExample()
        {
            Assert.DoesNotThrow(() => Problems.SmallestMultipleExample(Helper.IsInteger));
        }

        [TestCase(232792560)]
        public void SmallestMultiple(int ans)
        {
            var answer = Problems.SmallestMultiple(Helper.IsInteger);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(385)]
        public void SumSquareNaturalNumbersExample(int ans)
        {
            var answer = Problems.SumSquareNaturalNumbersExample();
            Assert.AreEqual(ans, answer);
        }

        [TestCase(3025)]
        public void SquareSumNaturalNumbersExample(int ans)
        {
            var answer = Problems.SquareSumNaturalNumbersExample();
            Assert.AreEqual(ans, answer);
        }

        [TestCase(2640, 10)]
        [TestCase(25164150, 100)]
        public void DifferenceSquareSumNaturalNumbersExample(int ans, int size)
        {
            // Note: This one was very easy
            var answer = Problems.SquareSumDifference(size);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(13, (ulong)6)]
        [TestCase(104743, (ulong)10001)]
        public void NthPrime(int ans, ulong nth)
        {
            var answer = Problems.NthPrime(Helper.DotNetPerlsIsPrime, nth);
            Assert.AreEqual(ans, answer);
        }

        [TestCase((ulong)5832, 4)]
        [TestCase((ulong)23514624000, 13)]
        public void LargestProductInASeries(ulong ans, int nth)
        {
            var answer = Problems.LargestProductInASeries(nth);
            Assert.AreEqual(ans, answer);
        }

        [TestCase(1000, 31875000)]
        public void SpecialPythagoreanTriplet(int c, int ans)
        {
            var answer = Problems.SpecialPythagoreanTriplet(c);
            Assert.AreEqual(ans, answer);
        }

        [TestCase((ulong)17, (ulong)10)]
        [TestCase((ulong)142913828922, (ulong)2000000)]
        [Category("Long Running")]
        public void SummationOfPrimes(ulong ans, ulong num)
        {
            var answer = Problems.SummationOfPrimesBelow(num, Helper.DotNetPerlsIsPrime);
            Assert.AreEqual(ans, answer);
        }
    }
}
