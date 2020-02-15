using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Exam Done";
        }
    }
}