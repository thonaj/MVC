using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaStoreMVC.Business.Repositories;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC.ViewModels
{
   public class PizzaOrderOptions
   {
      [Required]
      [Display(Name = "Your Sauce Options")]
      public List<SelectListItem> sauces { get; set; }
      [Required]
      [Display(Name = "Your Crust Options")]
      public List<SelectListItem> crust { get; set; }
      public List<SelectListItem> cheeses { get; set; }
      public List<SelectListItem> sizes { get; set; }
      public List<SelectListItem> toppings { get; set; }

      public PizzaOrderOptions()
      {
         sauces = GetSauceOptions();
         crust = new List<SelectListItem>();
         cheeses = new List<SelectListItem>();
         sizes = new List<SelectListItem>();
         toppings = new List<SelectListItem>();
      }

      private List<SelectListItem> GetSauceOptions()
      {
         var sauces = SauceRepo.getSauces();
         var sauceoptions = new List<SelectListItem>();

         foreach (var sauce in sauces)
         {
            sauceoptions.Add(new SelectListItem() { Text = sauce.Name, Value = sauce.IngredientId.ToString() });
         }

         return sauceoptions;
      }
   }
}