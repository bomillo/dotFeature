using System.ComponentModel.DataAnnotations;
using DotFeature.Base.Interfaces.Common;

namespace DotFeature.Example.ConsoleApp.FeatureManagement
{
    internal class RandomReleaseStrategy : IReleaseStrategy<ConsoleAppEvaluationContext>
    {
        [Range(0,1)]
        public float Probability { get; set; } = 0.5f;

        public Task<bool> EvaluateStrategyAsync(ConsoleAppEvaluationContext context)
        {
            return Task.FromResult(Random.Shared.NextDouble() < Probability);
        }
    }
}
