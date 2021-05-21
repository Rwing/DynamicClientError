using Bar430.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Bar430.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class Bar430Controller : AbpController
    {
        protected Bar430Controller()
        {
            LocalizationResource = typeof(Bar430Resource);
        }
    }
}