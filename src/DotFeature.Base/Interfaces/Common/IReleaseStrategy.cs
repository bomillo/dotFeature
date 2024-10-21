using System.Threading.Tasks;

namespace DotFeature.Base.Interfaces.Common
{
    public interface IReleaseStrategy<TContext> where TContext : IEvaluationContext
    {
        public Task<bool> EvaluateStrategyAsync(TContext context);
    }
}
