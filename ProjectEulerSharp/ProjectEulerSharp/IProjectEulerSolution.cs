namespace ProjectEulerSharp
{
    /// <summary>
    /// All project euler problems have a text box for the solution.
    /// </summary>
    internal interface IProjectEulerSolution
    {
        /// <summary>
        /// Solve the problem.
        /// </summary>
        /// <returns>Returns the solution to the problem as a string.</returns>
        string Solve();
    }
}