using System;

namespace DotFeature.Base.Interfaces.Common
{
    public interface IFeatureFlag<TContext> where TContext : class, IEvaluationContext
    {
        public string Key { get; }

        public bool DefaultValue { get; }

        public string DisplayName { get; }

        public string Description { get; }

        public Func<IReleaseStrategy<TContext>> CreateDefaultStrategy { get; }
    }
}
