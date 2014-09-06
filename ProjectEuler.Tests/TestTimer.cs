using System;
using System.Diagnostics;
using NUnit.Framework;

namespace ProjectEuler.Tests
{
    public abstract class TestTimer
    {
        private Stopwatch sw; 

        [SetUp]
        public virtual void SetUp()
        {
            sw = new Stopwatch();
            sw.Start();
        }

        [TearDown]
        public virtual void TearDown()
        {
            Console.WriteLine("Problem solved in {0} ms.", sw.ElapsedMilliseconds);
            sw.Stop();
            sw = null;
        }
    }
}
