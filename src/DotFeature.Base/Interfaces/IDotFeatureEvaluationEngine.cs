using DotFeature.Base.Interfaces.Common;
using System.Threading.Tasks;

namespace DotFeature.Base.Interfaces
{
    public interface IDotFeatureEvaluationEngine<TFlag, TContext> where TFlag : IFeatureFlag<TContext> where TContext : class, IEvaluationContext
    {
        public Task<bool> EvaluateAsync(TContext context);
    }
}