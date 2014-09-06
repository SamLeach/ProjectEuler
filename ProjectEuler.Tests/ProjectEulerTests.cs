namespace ProjectEuler.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class ProjectEulerTests : SolutionTests
    {
        public override ISolutions Create()
        {
            return new ProjectEulerSolutions();
        }
    }
}