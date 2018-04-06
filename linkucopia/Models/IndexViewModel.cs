using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace linkucopia
{
     public class IndexViewModel
     {
          public Aircraft[] Planes { get; set; }
          public Pilot[] Crew { get; set; }

          public int LocationCriterion { get; set; }
          [DataType(DataType.Currency)]
          public decimal MaxCostCriterion { get; set; }
          public int MinCapacityCriterion { get; set; }
          [DisplayFormat(DataFormatString = "{0}nm")]
          public int MinRangeCriterion { get; set; }

          public List<SelectListItem> LocationOptions { get; set; }
          [DataType(DataType.Currency)]
          public decimal MaxCostOption { get; set; }
          [DataType(DataType.Currency)]
          public decimal MinCostOption { get; set; }
          public int MaxCapacityOption { get; set; }
          public int MinCapacityOption { get; set; }
          [DisplayFormat(DataFormatString = "{0}nm")]
          public int MaxRangeOption { get; set; }
          [DisplayFormat(DataFormatString = "{0}nm")]
          public int MinRangeOption { get; set; }

     }  //class
}  //namespace