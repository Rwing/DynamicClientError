using System;
using System.Collections.Generic;
using System.Text;
using Foo400.Localization;
using Volo.Abp.Application.Services;

namespace Foo400
{
    /* Inherit your application services from this class.
     */
    public abstract class Foo400AppService : ApplicationService
    {
        protected Foo400AppService()
        {
            LocalizationResource = typeof(Foo400Resource);
        }
    }
}
