using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace linkucopia
{ 
     public class Location
     {
          public int Id { get; set; }
          public string Name { get; set; }

          public Location(int id, string name)
          {
               Id = id;
               Name = name;
          }
     }  //class
} //namespace