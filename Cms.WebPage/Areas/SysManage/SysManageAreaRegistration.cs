﻿using System.Web.Mvc;

namespace Cms.WebPage.Areas.SysManage
{
    public class SysManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SysManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "SysManage_default",
                "SysManage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "Cms.WebPage.Areas.SysManage.Controllers" }
            );
        }
    }
}