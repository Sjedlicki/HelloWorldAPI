using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeChallenge.Sample.Domain.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CodeChallenge
{
    public class HomeController : Controller
    {
        public HomeController()
        { 
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}