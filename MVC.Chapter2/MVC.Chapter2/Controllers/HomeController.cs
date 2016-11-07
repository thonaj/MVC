﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Chapter2.Models;

namespace MVC.Chapter2.Controllers
{
    public class HomeController : Controller
    {
      // GET: Home
      public ViewResult Index()
      {
         int hour = DateTime.Now.Hour;
         ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
         return View();
      }
      [HttpGet]
      public ViewResult RsvpForm()
      {
         return View();
      }

      [HttpPost]
      public ViewResult RsvpForm(GuestResponse guestResponse)
      {
         // TODO: Email response to the party organizer            
         return View("Thanks", guestResponse);
      }  
   }
} 