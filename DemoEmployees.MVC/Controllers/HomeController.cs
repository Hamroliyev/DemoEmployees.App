using DemoEmployees.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace DemoEmployees.MVC.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment Environment;

        public HomeController(IHostingEnvironment _environment)
        {
            Environment = _environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile)
        {
            List<Employee> employees = new List<Employee>();
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            string filePath = string.Empty;
            if (postedFile != null)
            {
                string path = Path.Combine(this.Environment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                filePath = path + Path.GetFileName(postedFile.FileName);
                string extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);

                string csvData = System.IO.File.ReadAllText(filePath);

                foreach (string row in csvData.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                        employees.Add(new Employee
                        {
                            PayrollNumber = row.Split(',')[0],
                            Forenames = row.Split(',')[1],
                            Surname = row.Split(',')[2],
                            Dateofbirth = Convert.ToDateTime(row.Split(',')[3]),
                            Telephone = row.Split(',')[4],
                            Mobile  = row.Split(',')[5],
                            Address = row.Split(',')[6],
                            SecondAdress = row.Split(',')[7],
                            PostCode = row.Split(',')[8],
                            EmailHome = row.Split(',')[9],
                            StartDate = Convert.ToDateTime(row.Split(',')[10]),
                        });
                    }
                }
            }

            return View(employees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
