using DotFeature.Base.Interfaces.Common;

namespace DotFeature.Example.ConsoleApp.FeatureManagement
{
    public class FeatureFlag : IFeatureFlag<ConsoleAppEvaluationContext>
    {
        public string Key => "FLAG";

        public bool DefaultValue => true;

        public string DisplayName => "Test feature flag";

        public string Description => "Some description";

        public Func<IReleaseStrategy<ConsoleAppEvaluationContext>> CreateDefaultStrategy => () => new RandomReleaseStrategy();

    }
}
