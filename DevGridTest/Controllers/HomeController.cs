using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevGridTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevGridTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(FakeData.Data, loadOptions);
        }
        public IActionResult Mode()
        {
            IEnumerable<Order> ord = FakeData.Data;
            return View(ord);
        }
        public object DataMode(DataSourceLoadOptions opt)
        {
            return DataSourceLoader.Load(FakeData.Data, opt);
        }
    }
}