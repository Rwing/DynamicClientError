using System;
using System.Collections.Generic;
using System.Text;
using Bar430.Localization;
using Volo.Abp.Application.Services;

namespace Bar430
{
    /* Inherit your application services from this class.
     */
    public abstract class Bar430AppService : ApplicationService
    {
        protected Bar430AppService()
        {
            LocalizationResource = typeof(Bar430Resource);
        }
    }
}
