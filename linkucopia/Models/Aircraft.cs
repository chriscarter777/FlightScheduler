using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace linkucopia
{
     public class Aircraft
     {
          public int Id { get; set; }
          public int Capacity { get; set; }
          [DataType(DataType.Currency)]
          public decimal Cost { get; set; }
          public int Location { get; set; }
          public int Range { get; set; }
          public string Type { get; set; }

          public Aircraft(int id, int capacity, decimal cost, int location, int range, string type)
          {
               Id = id;
               Capacity = capacity;
               Cost = cost;
               Location = location;
               Range = range;
               Type = type;
          }
     }  //class
}  //namespace