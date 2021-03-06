﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Helpers
{
    public class DefaultHelpLinkActionFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext context)
        {

            if (context.Controller is Controller)
            {
                var controller = context.Controller as Controller;

                string controllerAreaName = controller.RouteData.Values["controller"].ToString();                

                string path = $"HelpFiles/{ controllerAreaName }.md";

                controller.ViewBag.Helplink = path;
                // HelpFiles/controller/action OR name                

            }

            base.OnResultExecuting(context);
        }
    }

}
