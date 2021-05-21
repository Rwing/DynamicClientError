using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Bar430
{
    [Dependency(ReplaceServices = true)]
    public class Bar430BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Bar430";
    }
}
