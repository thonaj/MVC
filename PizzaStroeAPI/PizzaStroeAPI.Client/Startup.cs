using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: OwinStartup(typeof(PizzaStroeAPI.Client.Startup))]

namespace PizzaStroeAPI.Client
{
   public class Startup
   {
      public void Configuration(IAppBuilder builder)
      {
         builder.UseCookieAuthentication(new CookieAuthenticationOptions()
         {
            AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
            CookieName = "pizzadough",
            CookieHttpOnly = true,
            LoginPath = new Microsoft.Owin.PathString("/account/login"),
            LogoutPath = new Microsoft.Owin.PathString("/account/logout")
         } );
      }
   }
}