using System;
using System.Globalization;

namespace ProjectEuler
{
    public static class Helper
    {
        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        public static bool IsInteger(decimal d)
        {
            return d % 1 == 0;
        }

        public static bool IsPrime(ulong n)
        {
            if (n == 1)
            {
                return false;
            }

            ulong copy = n;
            n--;
            for (; n > 1; n--)
            {
                if (copy % n == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void IsPalindrome(long n)
        {
            int numberOfDigits = 0;
            while (n / 10 > 0)
            {
                numberOfDigits++;
                n = n / 10;
            }
        }

        public static bool IsPalindromeToString(long n)
        {
            var chara = n.ToString(CultureInfo.InvariantCulture).ToCharArray();
            Array.Reverse(chara);
            return Int32.Parse(new string(chara)) == n;
        }

        public static bool DotNetPerlsIsPrime(ulong candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (ulong i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
