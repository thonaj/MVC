namespace PizzaStroeAPI.Client.Models
{
   public class Name
   {
      public string First { get; set; }
      public string Last { get; set; }

      public override string ToString()
      {
         return string.Format("{0} {1}", First, Last);
      }
   }
}