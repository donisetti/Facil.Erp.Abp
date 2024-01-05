﻿using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Facil.Erp.Web.Views
{
    public abstract class ErpRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ErpRazorPage()
        {
            LocalizationSourceName = ErpConsts.LocalizationSourceName;
        }
    }
}
