using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PizzaStoreMVC2.Client.DomainModels
{
   public class PizzaDTO
   {
      public PizzaDTO()
      {
         this.Crust = new CrustDTO();
         this.Sauce = new SauceDTO();
         this.Size = new SizeDTO();
         this.toppings = new List<ToppingDTO>();
         this.cheeses = new List<CheeseDTO>();
         //this.Name = this.ToString();
      }
      public string Name { get; set; }
      public int CrustId { get; set; }
      public int SauceId { get; set; }
      public int SizeId { get; set; }
      public Nullable<int> OrderId { get; set; }
      public virtual CrustDTO Crust { get; set; }
      public virtual OrderDTO Order { get; set; }
      public virtual SauceDTO Sauce { get; set; }
      public virtual SizeDTO Size { get; set; }
      public List<ToppingDTO> toppings { get; set; }
      public List<CheeseDTO> cheeses { get; set; }
   }
}