namespace ProjectEuler.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class BruteForceTests : SolutionTests
    {
        public override ISolutions Create()
        {
            return new BruteForceSolutions();
        }
    }
}
