using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Foo400
{
    [Dependency(ReplaceServices = true)]
    public class Foo400BrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Foo400";
    }
}
