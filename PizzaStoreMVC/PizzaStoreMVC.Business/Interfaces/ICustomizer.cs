using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaStoreMVC.Business.Interfaces
{
   public interface ICustomizer
   {
      bool Add<T>(T item);
      bool Remove<T>(T item);
      decimal Compute<T>(T item);
   }
}