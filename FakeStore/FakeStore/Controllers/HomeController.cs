using FakeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FakeStore.Controllers
{
    public class HomeController : Controller
    {
        private List<CostumerModel> _costumersList = new List<CostumerModel>();
        CostumerDAO costumerDAO = new CostumerDAO();
        public ActionResult Index()
        {
            _costumersList.Add(new CostumerModel { FirstName = "Gustavo", LastName = "Pereira", Gender = "Male",costumerSince = DateTime.Now, IsActive = true });
            _costumersList.Add(new CostumerModel { FirstName = "Aline", LastName = "Piazon", Gender = "Female", costumerSince = DateTime.Now, IsActive = true });
           
            return View(_costumersList);
        }

    }
}