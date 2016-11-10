using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.Client
{
   public class ValidAction : ActionFilterAttribute
   {
      private System.Timers.Timer t = new System.Timers.Timer();
      public override void OnActionExecuting(ActionExecutingContext filterContext)
      {
         var context = filterContext.RequestContext.HttpContext;

         if (context.Request.UserAgent.Contains("IE"))
         {
            context.Response.Redirect("ie/index");
         }
         t.Start();
      }
      public override void OnActionExecuted(ActionExecutedContext filterContext)
      {
         var context = filterContext.RequestContext.HttpContext;

         if (context.Request.UserAgent.Contains("IE"))
         {
            context.Response.Redirect("ie/index");
         }
         t.Stop();
         //Log.Write(t.Interval.ToString());
      }
   }
}