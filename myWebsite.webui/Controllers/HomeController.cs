using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myWebsite.data.Abstract;
using myWebsite.entity;
using myWebsite.webui.Models;

namespace myWebsite.webui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserRepository _userRepository;
        private IJobRepository _jobRepository;

        public HomeController(IUserRepository userRepository,IJobRepository jobRepository)
        {
            this._userRepository = userRepository;
            this._jobRepository = jobRepository;
        }
        
        public IActionResult Index()
        {
            ;
            // var user = new User()
            // {
            //      ShortAbout = "I'm a junior developer"
            //  };
            
            return View(_userRepository.getUser());
        }

        public IActionResult About()
        {
            UserDetailsJobsView userDetailsJobsView = new UserDetailsJobsView()
            {
                UserDetail = _userRepository.GetUserWithDetails(),
                Jobs = _jobRepository.GetAll()
            };
            return View(userDetailsJobsView);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Portfolyo()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}