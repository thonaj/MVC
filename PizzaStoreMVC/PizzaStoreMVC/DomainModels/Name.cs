using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaStoreMVC.DomainModels
{
   public class Name
   {
      [Required(ErrorMessage ="Please enter your first name")]
      [Display(Name ="First Name")]
      [DataType(DataType.Text)]
      [StringLength(50)]
      public string First { get; set; }
      [Required(ErrorMessage = "Pleaase enter your last name")]
      [Display(Name = "Last Name")]
      [DataType(DataType.Text)]
      [StringLength(50)]
      public string Last { get; set; }
   }
}