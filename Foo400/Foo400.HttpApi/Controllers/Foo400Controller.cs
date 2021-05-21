using Foo400.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Foo400.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Foo400Controller : AbpController
    {
        protected Foo400Controller()
        {
            LocalizationResource = typeof(Foo400Resource);
        }
    }
}