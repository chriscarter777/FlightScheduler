using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using linkucopia;
using linkucopia.Controllers;
using NUnit.Framework;

namespace linkucopia.Tests.Controllers
{
     [TestFixture]
     public class HomeControllerTest
     {
          [Test]
          public void IndexReturnsInitialView()
          {
               HomeController controller = new HomeController();
               ViewResult result = controller.Index() as ViewResult;
               Assert.IsNotNull(result);
               Assert.IsInstanceOf<IndexViewModel>(result.Model);
          }

          [Test]
          public void IndexReturnsFilteredDataOnPost()
          {
               HomeController controller = new HomeController();
               IndexViewModel model = new IndexViewModel();
               model.MinCapacityCriterion = 200;
               model.MaxCostCriterion = 35000;
               model.MinRangeCriterion = 1100;
               model.LocationCriterion = 1;
               ViewResult result = controller.Index(model) as ViewResult;
               Assert.IsNotNull(result);
               Assert.IsNotNull(model.Planes);
               Assert.IsNotNull(model.Crew);
          }

          [Test]
          public void AboutReturnsView()
          {
               HomeController controller = new HomeController();
               ViewResult result = controller.About() as ViewResult;
               Assert.IsNotNull(result);
          }
     }
}
