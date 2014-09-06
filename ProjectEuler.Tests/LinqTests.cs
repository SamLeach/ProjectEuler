namespace ProjectEuler.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class LinqTests : SolutionTests
    {
        public override ISolutions Create()
        {
            return new LinqSolutions();
        }
    }
}
