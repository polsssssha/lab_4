namespace SortConsoleApp.Tester.classes
{
    public record TestResult<TResult>(int ID, string AlgorithmName, TResult Result, TResult[] LocalResults)
    {
        public int ID { get; } = ID;
        public string AlgorithmName { get; } = AlgorithmName;
        public TResult Result { get; } = Result;
        public TResult[] LocalResults { get; } = LocalResults;
    }
}
