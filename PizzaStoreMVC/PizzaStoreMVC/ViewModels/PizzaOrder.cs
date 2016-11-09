using PizzaStoreMVC.DomainModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.ViewModels
{
   public class PizzaOrder
   {
      [Required(ErrorMessage ="details")]
      public List<PizzaOrderDetail> details { get; set; }

      [Required(ErrorMessage ="customer")]
      public Customer customer { get; set; }

      [Required(ErrorMessage ="option")]
      public PizzaOrderOptions Option { get; set; }

      public PizzaOrder()
      {
         Option = new PizzaOrderOptions();
         details = new List<PizzaOrderDetail>();
      }
   }
}