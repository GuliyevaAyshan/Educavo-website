using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduCavoFinal.Filters
{
    public class Auth: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session.GetString("ValidCustomer") == null)
            {
                filterContext.Result = new RedirectResult("~/home");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}
