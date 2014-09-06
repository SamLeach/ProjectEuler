namespace ProjectEuler
{
    /// <summary>
    /// Naive or brute force solutions. 
    /// So I can trace the routes taken to reach an optimised solutions.
    /// </summary>
    public class BruteForceSolutions : ISolutions
    {
        public int Problem1(int n)
        {
            return BruteForceProblems.Multiplesof3And5(n);
        }

        public int Problem2(int n)
        {
            return BruteForceProblems.Fibanacci(Shared.IsEven, n);
        }

        public long Problem3(decimal n)
        {
            return BruteForceProblems.PacoLargestPrimeFactor(Shared.IsInteger, Shared.DotNetPerlsIsPrime, n);
        }

        public int Problem4(int n)
        {
            return BruteForceProblems.LargestPalindromeFromProductOfTwoDigitNumbers(Shared.IsPalindromeToString, n);
        }

        public decimal Problem5(decimal n)
        {
            return BruteForceProblems.SmallestMultiple(Shared.IsInteger, n);
        }

        public double Problem6(double n)
        {
            return BruteForceProblems.SquareSumDifference(n);
        }

        public ulong Problem7(ulong n)
        {
            return BruteForceProblems.NthPrime(Shared.DotNetPerlsIsPrime, n);
        }

        public ulong Problem8(int n)
        {
            return BruteForceProblems.LargestProductInASeries(n);
        }

        public int Problem9(int n)
        {
            return BruteForceProblems.SpecialPythagoreanTriplet(n);
        }

        public ulong Problem10(ulong n)
        {
            return BruteForceProblems.SummationOfPrimesBelow(n, Shared.DotNetPerlsIsPrime);
        }
    }
}
