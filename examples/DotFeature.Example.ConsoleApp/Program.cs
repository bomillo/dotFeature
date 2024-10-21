using DotFeature.Base;
using DotFeature.Base.State;
using DotFeature.Example.ConsoleApp.FeatureManagement;

Console.WriteLine("Hello, dotFeature!\n");

var evaluationContext = new ConsoleAppEvaluationContext();
var stateManager = new InMemoryStateManager();
var evaluationEngine = new DotFeatureEvaluationEngine<FeatureFlag, ConsoleAppEvaluationContext>(stateManager);

stateManager.SetStrategyForFlagAsync(new FeatureFlag(), new RandomReleaseStrategy() { Probability = 0 }).Wait();
Console.WriteLine("-------------------- Probability = 0%");
await TestAndPrintFlagEvaluation(6);

stateManager.SetStrategyForFlagAsync(new FeatureFlag(), new RandomReleaseStrategy() { Probability = 1 }).Wait();
Console.WriteLine("-------------------- Probability = 100%");
await TestAndPrintFlagEvaluation(6);

stateManager.SetStrategyForFlagAsync(new FeatureFlag(), new RandomReleaseStrategy() { Probability = .5f }).Wait();
Console.WriteLine("-------------------- Probability = 50%");
await TestAndPrintFlagEvaluation(12);

Console.ReadLine();



async Task TestAndPrintFlagEvaluation(int repeats)
{
    for (int i = 0; i < repeats; i++)
    {
        Console.WriteLine(await evaluationEngine.EvaluateAsync(evaluationContext));
    }
}