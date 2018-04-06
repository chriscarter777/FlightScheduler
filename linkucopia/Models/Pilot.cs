using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace linkucopia
{
     public class Pilot
     {
          public int Id { get; set; }
          public int[] CheckedAircraft { get; set; }
          public string FirstName { get; set; }
          public string LastName { get; set; }
          public int Location { get; set; }

          public Pilot(int id, int[] checkedac, string first, string last, int location)
          {
               Id = id;
               CheckedAircraft = checkedac;
               FirstName = first;
               LastName = last;
               Location = location;
          }
     }  //class
} //namespace