using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace linkucopia
{
     public static class TestData
     {
          public static readonly Aircraft[] PlaneData = new Aircraft[]
          {
               new Aircraft(1, 200, 10999, 1, 1100, "B737"),
               new Aircraft(2, 500, 34999, 1, 3200, "B747"),
               new Aircraft(3, 300, 27999, 1, 2800, "B767"),
               new Aircraft(4, 450, 29999, 1, 3100, "B777"),
               new Aircraft(5, 250, 15999, 1, 2200, "B787"),
               new Aircraft(1, 200, 10777, 2, 1100, "B737"),
               new Aircraft(2, 500, 34777, 2, 3200, "B747"),
               new Aircraft(3, 300, 27777, 2, 2800, "B767"),
               new Aircraft(4, 450, 29777, 2, 3100, "B777"),
               new Aircraft(5, 250, 15777, 2, 2200, "B787"),
               new Aircraft(1, 200, 10888, 3, 1100, "B737"),
               new Aircraft(2, 500, 34888, 3, 3200, "B747"),
               new Aircraft(3, 300, 27888, 3, 2800, "B767"),
               new Aircraft(4, 450, 29888, 3, 3100, "B777"),
               new Aircraft(5, 250, 15888, 3, 2200, "B787")
          };

          public static readonly Pilot[] CrewData = new Pilot[]
          {
               new Pilot(101, new int[] {1}, "Peter", "Piper", 1),
               new Pilot(112, new int[] {3, 4, 5}, "Ewan", "McGregor", 1),
               new Pilot(123, new int[] {1, 4, 5}, "Indira", "Ghandi", 1),
               new Pilot(134, new int[] {2}, "Elizabeth", "Taylor", 1),
               new Pilot(145, new int[] {2, 3, 4, 5}, "John", "Snow", 1),
               new Pilot(101, new int[] {1}, "Peter", "Piperski", 2),
               new Pilot(112, new int[] {3, 4, 5}, "Ewan", "McGregorski", 2),
               new Pilot(123, new int[] {1, 4, 5}, "Indira", "Ghandiski", 2),
               new Pilot(134, new int[] {2}, "Elizabeth", "Taylorski", 2),
               new Pilot(145, new int[] {2, 3, 4, 5}, "John", "Snowski", 2),
               new Pilot(101, new int[] {1}, "Peter", "MacPiper", 3),
               new Pilot(112, new int[] {3, 4, 5}, "Ewan", "MacMcGregor", 3),
               new Pilot(123, new int[] {1, 4, 5}, "Indira", "MacGhandi", 3),
               new Pilot(134, new int[] {2}, "Elizabeth", "MacTaylor", 3),
               new Pilot(145, new int[] {2, 3, 4, 5}, "John", "MacSnow", 3),
          };

          public static readonly Location[] LocationData = new Location[]
          {
               new Location(1, "USA"),
               new Location(2, "Russia"),
               new Location(3, "Scotland")
          };

     }  //class
}  //namespace