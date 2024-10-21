using DotFeature.Base.Interfaces;
using DotFeature.Base.Interfaces.Common;
using DotFeature.Base.Interfaces.State;
using System.Threading.Tasks;

namespace DotFeature.Base
{
    public class DotFeatureEvaluationEngine<TFlag, TContext> : IDotFeatureEvaluationEngine<TFlag, TContext> where TFlag : IFeatureFlag<TContext>, new() where TContext : class, IEvaluationContext
    {
        public DotFeatureEvaluationEngine(IStateManager stateManager)
        {
            StateManager = stateManager;
        }

        private IStateManager StateManager { get; set; }

        public async Task<bool> EvaluateAsync(TContext context)
        {
            var strategy = await StateManager.GetStrategyForFlagAsync(new TFlag());

            return await strategy.EvaluateStrategyAsync(context);            
        }
    }
}
