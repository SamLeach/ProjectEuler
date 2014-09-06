namespace ProjectEuler.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class OptimisedTests : SolutionTests
    {
        public override ISolutions Create()
        {
            return new OptimisedSolutions();
        }
    }
}