using DotFeature.Base.Interfaces.Common;
using System.Threading.Tasks;

namespace DotFeature.Base.Interfaces.State
{
    public interface IStateManager
    {
        public Task<IReleaseStrategy<T>> GetStrategyForFlagAsync<T>(IFeatureFlag<T> flag) where T : class, IEvaluationContext;

        public Task SetStrategyForFlagAsync<T>(IFeatureFlag<T> flag, IReleaseStrategy<T> strategy) where T : class, IEvaluationContext;
    }
}