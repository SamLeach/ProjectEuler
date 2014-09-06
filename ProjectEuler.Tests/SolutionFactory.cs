namespace ProjectEuler.Tests
{
    public class SolutionFactory
    {
        /// <summary>
        /// Solution factory method
        /// </summary>
        /// <param name="solutionType">The solution type</param>
        /// <returns>An ISolutions implementation</returns>
        public virtual ISolutions Create(SolutionType solutionType)
        {
            switch (solutionType)
            {
                case SolutionType.BruteForce:
                    return new BruteForceSolutions();
                case SolutionType.Linq:
                    return new LinqSolutions();
                case SolutionType.Optimised:
                    return new OptimisedSolutions();
                case SolutionType.ProjectEuler:
                    return new ProjectEulerSolutions();
                default:
                    return new ProjectEulerSolutions();
            }
        }
    }
}
