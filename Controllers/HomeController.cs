using DemoMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using System.Data.SqlClient;
using Dapper;
using System.Net.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
//using System.Web.Security;
namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        [HttpGet]
        public IActionResult Login() { return View(); }
        [HttpPost]
       // [Authorize]
        public IActionResult Login(IFormCollection f)
        {
            string uname, passwd;
            int flag = 0;
            uname = f["username"];
            passwd = f["passwd"];
            string connectionString = "Server= 192.168.0.23,1427;Initial Catalog=interns;Integrated Security=False;user id = Interns;password=test;";
            string selectCmd = "Select passwd From loginuser where username = @uname";
            var val = new { uname = uname};
            using (IDbConnection conn = new SqlConnection(connectionString))
            {
                string result = conn.QueryFirstOrDefault<string>(selectCmd,val);
                if(result == passwd)
                {
                    flag = 1;
                }
            }
            if(flag == 1)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, f["username"]),
                };
                var claimsIdentity = new ClaimsIdentity(claims, 
                    CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {

                };
                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), authProperties);
                return RedirectToAction("Index","Product");
            }
            else
            {
                ViewBag.ErrorMessage = "Incorrect Credentials";
                return RedirectToAction("Login", "Home");
            }

        }
        [HttpGet]
        public IActionResult Logout() { return View(); }
        [HttpPost]
        public IActionResult Logout(IFormCollection f)
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Home");
        }
    }
}
