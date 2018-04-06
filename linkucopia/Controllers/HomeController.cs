using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace linkucopia.Controllers
{
     public class HomeController : Controller
     {
          [HttpGet]
          public ActionResult Index()
          {
               Debug.WriteLine("New!");
               IndexViewModel model = new IndexViewModel();
               PopulateModelOptions(model);
               PopulateModelInitial(model);
               return View("Index", model);
          }

          [HttpPost]
          public ActionResult Index(IndexViewModel model)
          {
               model.Planes = TestData.PlaneData.Where(p => p.Capacity >= model.MinCapacityCriterion && p.Cost <= model.MaxCostCriterion && p.Range >= model.MinRangeCriterion && p.Location == model.LocationCriterion).OrderBy(x => x.Cost).ToArray();
               model.Crew = TestData.CrewData.Where(c => c.Location == model.LocationCriterion && c.CheckedAircraft.Intersect(model.Planes.Select(x => x.Id)).Count() > 0).OrderBy(x => x.LastName).ToArray();
               PopulateModelOptions(model);
               return View("Index", model);
          }

          public ActionResult About()
          {
               return View("About");
          }

          private void PopulateModelOptions(IndexViewModel model)
          {
               model.MaxCapacityOption = TestData.PlaneData.Select(x => x.Capacity).Max();
               model.MinCapacityOption = TestData.PlaneData.Select(x => x.Capacity).Min();
               model.MaxCostOption = TestData.PlaneData.Select(x => x.Cost).Max();
               model.MinCostOption = TestData.PlaneData.Select(x => x.Cost).Min();
               model.MaxRangeOption = TestData.PlaneData.Select(x => x.Range).Max();
               model.MinRangeOption = TestData.PlaneData.Select(x => x.Range).Min();
               model.LocationOptions = new List<SelectListItem>();
               foreach (Location loc in TestData.LocationData)
               {
                    model.LocationOptions.Add(new SelectListItem { Value = loc.Id.ToString(), Text = loc.Name });
               }
          }  //PopulateModelOptions

          private void PopulateModelInitial(IndexViewModel model)
          {
               model.LocationCriterion = 1;
               model.MinCapacityCriterion = model.MinCapacityOption;
               model.MaxCostCriterion = model.MaxCostOption;
               model.MinRangeCriterion = model.MinRangeOption;
          }  //PopulateModelInitial

     }  //class
}  //namespace