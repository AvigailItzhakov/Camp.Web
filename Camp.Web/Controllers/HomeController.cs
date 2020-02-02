using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Camp.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Camp.Data;
using System.Net;
using Microsoft.AspNetCore.Http;

namespace Camp.Web.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _enviorment;
        private string _connectionString;
        public HomeController(IHostingEnvironment enviornment, IConfiguration configuration)
        {
            _enviorment = enviornment;
            _connectionString = configuration.GetConnectionString("ConStr");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCamper()
        {
            return View();
        }

        public IActionResult AddCamperToData(Camper camper)
        {
            var db = new CampRepository(_connectionString);
            string yearString = HttpContext.Session.GetString("year");
            camper.Year = int.Parse(yearString);
            db.AddCamper(camper);
            return Redirect("/home/ViewCampers");
        }

        public IActionResult ViewCampers()
        {
            var db = new CampRepository(_connectionString);

            string yearString = HttpContext.Session.GetString("year");
            int year = int.Parse(yearString);

            return View(db.GetCampers(year));
        }
        public IActionResult ViewCamper(int id)
        {

            var db = new CampRepository(_connectionString);
            Camper c = db.GetCamperInfo(id);
            return View(c);
        }

        public IActionResult SetYear(string year)
        {
HttpContext.Session.SetString("year", year);
            return Redirect("/home/ViewCampers");

        }



    }
}
