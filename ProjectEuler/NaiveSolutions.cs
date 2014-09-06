namespace ProjectEuler
{
    public class NaiveSolutions : ISolutions
    {
        public int Problem1(int n)
        {
            return Problems.Multiplesof3And5(n);
        }

        public int Problem2(int n)
        {
            return Problems.Fibanacci(Helper.IsEven, n);
        }

        public long Problem3(decimal n)
        {
            return Problems.PacoLargestPrimeFactor(Helper.IsInteger, Helper.DotNetPerlsIsPrime, n);
        }

        public int Problem4(int n)
        {
            return Problems.LargestPalindromeFromProductOfTwoDigitNumbers(Helper.IsPalindromeToString, n);
        }

        public decimal Problem5(decimal n)
        {
            return Problems.SmallestMultiple(Helper.IsInteger, n);
        }

        public double Problem6(double n)
        {
            return Problems.SquareSumDifference(n);
        }

        public ulong Problem7(ulong n)
        {
            return Problems.NthPrime(Helper.DotNetPerlsIsPrime, n);
        }

        public ulong Problem8(int n)
        {
            return Problems.LargestProductInASeries(n);
        }

        public int Problem9(int n)
        {
            return Problems.SpecialPythagoreanTriplet(n);
        }

        public ulong Problem10(ulong n)
        {
            return Problems.SummationOfPrimesBelow(n, Helper.DotNetPerlsIsPrime);
        }
    }
}
