using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace PizzaStroeAPI.Client
{
   public class Agent007 : ActionFilterAttribute
   {
      public override void OnActionExecuting(HttpActionContext actionContext)
      {
         var ctx = HttpContext.Current;
         var auth = ctx.Request.GetOwinContext().Authentication;

         if(!auth.User.Identity.IsAuthenticated)
         {
            ctx.Response.Redirect("user/account/login");
         }

      }
   }
}