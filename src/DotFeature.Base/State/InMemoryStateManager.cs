using DotFeature.Base.Interfaces.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotFeature.Base.State
{
    public class InMemoryStateManager : NonPersistedStateManager
    {
        IDictionary<string, object> _strategies = new Dictionary<string, object>();

        public override Task<IReleaseStrategy<T>> GetStrategyForFlagAsync<T>(IFeatureFlag<T> flag)
        {
            if (_strategies[flag.Key] is IReleaseStrategy<T> strategy) 
            {
                return Task.FromResult(strategy);
            }

            return base.GetStrategyForFlagAsync(flag);
        }

        public override Task SetStrategyForFlagAsync<T>(IFeatureFlag<T> flag, IReleaseStrategy<T> strategy)
        {
            _strategies[flag.Key] = strategy;
            return Task.CompletedTask;
        }
    }
}
