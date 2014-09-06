using System;

namespace ProjectEuler 
{
    /// <summary>
    /// Solutions that Project Euler gives you when you solve a problem
    /// </summary>
    public class ProjectEulerSolutions : ISolutions
    {
        public int Problem1(int target)
        {
            //target=999
            //Function SumDivisibleBy(n)
            //  p=target div n
            //  return n*(p*(p+1)) div 2
            //EndFunction
            //Output SumDivisibleBy(3)+SumDivisibleBy(5)-SumDivisibleBy(15) 

            return SumDivisibleBy(target, 3) + SumDivisibleBy(target, 5) - SumDivisibleBy(target, 15);
        }

        /// <summary>
        /// For problem 1
        /// </summary>
        /// <param name="target">The target</param>
        /// <param name="n">The number divisible by</param>
        /// <returns>Some magic</returns>
        private int SumDivisibleBy(int target, int n)
        {
            // 999 / 3 = 333
            // 999 / 5 = 199
            // 999 / 15 = 66
            int p = target / n;

            // TODO: Understand wtf is going on here
            return n * (p * (p + 1)) / 2;
        }

        public int Problem2(int limit)
        {
            //limit=4000000
            //sum=0
            //a=1
            //b=1
            //c=a+b
            //while c<limit
            //  sum=sum+c
            //  a=b+c
            //  b=c+a
            //  c=a+b
            //output sum

            int sum = 0;
            int a = 1;
            int b = 1;
            int c = a + b;

            while (c < limit)
            {
                sum = sum + c;
                a = a + c;
                b = c + a;
                c = a + b;
            }
            return sum;
        }

        public long Problem3(decimal n)
        {
            throw new NotImplementedException();
        }

        public int Problem4(int n)
        {
            throw new NotImplementedException();
        }

        public decimal Problem5(decimal n)
        {
            throw new NotImplementedException();
        }

        public double Problem6(double n)
        {
            throw new NotImplementedException();
        }

        public ulong Problem7(ulong n)
        {
            throw new NotImplementedException();
        }

        public ulong Problem8(int n)
        {
            throw new NotImplementedException();
        }

        public int Problem9(int n)
        {
            throw new NotImplementedException();
        }

        public ulong Problem10(ulong n)
        {
            throw new NotImplementedException();
        }
    }
}
