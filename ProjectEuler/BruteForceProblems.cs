using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ProjectEuler
{
    /// <summary>
    /// Naive functions involved in solving problems initially.
    /// </summary>
    public static class BruteForceProblems
    {
        public static int Multiplesof3And5(int num)
        {
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static IList<int> EvenFibonacciNumbers(Func<int, bool> isEven, int n = 10) // 4 million
        {
            var r = new List<int>();
            int m = Fib(n, isEven, ref r);
            return r;
        }

        private static int Fib(int n, Func<int, bool> isEven, ref List<int> r)
        {
            // does not work
            if (n == 10)
            {
                return n;
            }

            if (isEven(n))
            {
                if (!r.Contains(n))
                {
                    r.Add(n);
                }
            }

            return Fib(n + 1, isEven, ref r) - Fib(n + 2, isEven, ref r);
        }

        public static int Fibanacci(Func<int, bool> isEven, int max = 4000000)
        {
            int sum = 2;
            int temp = 0;
            int n = 1;
            int m = 2;

            while (n <= max || m <= max)
            {
                temp = n + m;

                if (isEven(temp))
                {
                    sum += temp;
                }

                n = m;
                m = temp;
            }
            return sum;
        }

        public static long PacoLargestPrimeFactor(Func<decimal, bool> isInteger, Func<ulong, bool> isPrime, decimal n = 600851475143)
        {
            for (int i = 3; i < n; i++)
            {
                decimal a = n / i;
                if (isInteger(a) && isPrime(Convert.ToUInt64(a)))
                {
                    return Convert.ToInt64(a);
                }
            }
            return 0;
        }

        public static ulong LargestPrimeFactor(Func<ulong, bool> isPrime, ulong n = 600851475143)
        {
            ulong largest = 0;
            for (ulong i = n; i > 0; i--)
            {
                for (ulong j = 0; j < n; j++)
                {
                    if (i * j == n) // factor
                    {
                        if (isPrime(j) && isPrime(i))
                        {
                            if (j > largest)
                            {
                                largest = j;
                            }

                            if (i > largest)
                            {
                                largest = i;
                            }
                        }

                        if (isPrime(i))
                        {
                            if (i > largest)
                            {
                                largest = i;
                            }
                        }
                        if (isPrime(j))
                        {
                            if (j > largest)
                            {
                                largest = j;
                            }
                        }
                    }
                }
            }
            return largest;
        }

        public static int LargestPalindromeFromProductOfTwoDigitNumbers(Func<long, bool> isPalindrome, int digits)
        {
            int num = digits;
            int max = 0;
            for (int i = num; i >= 0; i--)
            {
                for (int j = num; j >= 0; j--)
                {
                    int k = i*j;
                    if (isPalindrome(k))
                    {
                        if (k > max)
                        {
                            max = k;
                        }
                    }
                }
            }
            return max;
        }

        public static void SmallestMultipleExample(Func<decimal, bool> isInteger, decimal n = 2520)
        {
            const int ten = 10;

            for (int i = ten; i >= ten; i--)
            {
                decimal r = n/i;
                var b = isInteger(r);
                if (!b)
                {
                    throw new Exception("This should not happen.");
                }
            }
        }

        public static decimal SmallestMultiple(Func<decimal, bool> isInteger, decimal n = 20)
        {
            decimal answer = 20;
            decimal returnCount = n;

            while (returnCount >= 1)
            {
                for (decimal i = n; i >= 1; i--)
                {
                    var r = answer / i;
                    if (!isInteger(r))
                    {
                        answer++;
                        returnCount = n;
                        break;
                    }
                    returnCount--;
                }
            }
            return answer;
        }

        public static double SumSquareNaturalNumbersExample(double n = 10)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(i, 2);
            }
            return sum;
        }

        public static double SquareSumNaturalNumbersExample(double n = 10)
        {
            var r = Math.Pow(Enumerable.Range(1, Convert.ToInt32(n)).Sum(), 2);
            return r;
        }

        public static double SquareSumDifference(double n = 10)
        {
            return SquareSumNaturalNumbersExample(n) - SumSquareNaturalNumbersExample(n);
        }

        public static ulong NthPrime(Func<ulong, bool> isPrime, ulong nth)
        {
            var primes = new List<ulong>();

            for (ulong i = 2;; i++)
            {
                if (isPrime(i))
                {
                    primes.Add(i);
                    if (Convert.ToUInt64(primes.Count) > nth - 1)
                    {
                        break;
                    }
                }
            }
            return primes.Last();
        }

        public static ulong LargestProductInASeries(int digits)
        {
            const string payload = @"7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            var ints = StringOfIntsToIntArray(payload);

            ulong answer = 0;

            for (int i = 0; i < ints.Count - digits; i++)
            {
                ulong temp = 1;

                for (int j = 0; j < digits; j++)
                {
                    temp *= ints[i + j];
                }

                if (temp > answer)
                {
                    answer = temp;
                }
            }

            return answer;
        }

        public static IList<ulong> StringOfIntsToIntArray(string s)
        {
            var ints = new List<ulong>();
            s.ToCharArray().ToList().ForEach(x => ints.Add(ulong.Parse(x.ToString(CultureInfo.InvariantCulture))));
            return ints;
        }

        public static int SpecialPythagoreanTriplet(int t)
        {
            for (int a = 1; a < t; a++)
            {
                for (int b = 1; b < t; b++)
                {
                    int c = t - a - b;

                    if (Convert.ToInt32(Math.Pow(a, 2)) + Convert.ToInt32(Math.Pow(b, 2)) == Convert.ToInt32(Math.Pow(c, 2)) && a < b)
                    {
                        return a * b * c;
                    }
                    
                }
            }
            return 0;
        }

        public static ulong SummationOfPrimesBelow(ulong n, Func<ulong, bool> isPrime)
        {
            ulong sum = 0;
            for (ulong i = 1; i < n; i++)
            {
                if (isPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
