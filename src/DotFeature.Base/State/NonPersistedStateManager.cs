using DotFeature.Base.Interfaces.Common;
using DotFeature.Base.Interfaces.State;
using System.Threading.Tasks;

namespace DotFeature.Base.State
{
    public class NonPersistedStateManager : IStateManager
    {
        virtual public Task<IReleaseStrategy<T>> GetStrategyForFlagAsync<T>(IFeatureFlag<T> flag) where T : class, IEvaluationContext 
            => Task.FromResult(flag.CreateDefaultStrategy());

        virtual public Task SetStrategyForFlagAsync<T>(IFeatureFlag<T> flag, IReleaseStrategy<T> strategy) where T : class, IEvaluationContext
            => throw new System.NotImplementedException();
    }
}
