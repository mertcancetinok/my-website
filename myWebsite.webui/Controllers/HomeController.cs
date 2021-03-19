using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using myWebsite.business.Abstract;
using myWebsite.data.Abstract;
using myWebsite.entity;
using myWebsite.webui.MailService;
using myWebsite.webui.Models;
using Newtonsoft.Json;

namespace myWebsite.webui.Controllers
{
    public class HomeController : Controller
    {

        private IUserService _userService;
        private IJobService _jobService;
        private ISkillService _skillService;
        private IContactService _contactService;
        private IPortfolyoService _portfolyoService;
        private IEmailService _emailService;
        public HomeController(IUserService userService, IJobService jobService, ISkillService skillService, IContactService contactService, IPortfolyoService portfolyoService, IEmailService emailService)
        {
            _userService = userService;
            _jobService = jobService;
            _skillService = skillService;
            _contactService = contactService;
            _portfolyoService = portfolyoService;
            _emailService = emailService;
        }

      
        
        public IActionResult Index()
        {
            var result = _userService.GetUser();
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                return View();
            }
            
            
        }

        public IActionResult About()
        {
            var resultDetails = _userService.GetUserWithDetails();
            var resultJob = _jobService.GetAll();
            var resultSkill = _skillService.GetAll();
            if(resultDetails.Success && resultJob.Success && resultSkill.Success)
            {
                UserDetailsJobsSkillView userDetailsJobsSkillView = new UserDetailsJobsSkillView()
                {
                    UserDetail = resultDetails.Data,
                    Jobs = resultJob.Data,
                    Skills = resultSkill.Data
                };
                return View(userDetailsJobsSkillView);
            }
            else
            {
                return View();
            }
           
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactModel contactModel)
        {
            if (ModelState.IsValid)
            {
                var entity = new Contact()
                {
                    Name = contactModel.Name,
                    Surname = contactModel.Surname,
                    Email = contactModel.Email,
                    Subject = contactModel.Subject
                };
                _contactService.Create(entity);
                var msg = new AlertMessage()
                {
                    Message = $"{entity.Name} mesajın bana iletildi seninle yakında iletişim kuracağım.Beklemede kal",
                    AlertType = "success"
                };
                await _emailService.SendEmailAsync("mertcancetinok.com - İletişim Talebi", $"Ad:{contactModel.Name} Soyad:{contactModel.Surname}   E-Mail:{contactModel.Email}<br>  {contactModel.Subject}");
                TempData["message"] = JsonConvert.SerializeObject(msg);
                return RedirectToAction("Contact");

            }

            return View();


        }

        public IActionResult Portfolyo()
        {
            var result = _portfolyoService.GetAll();
            if (result.Success)
            {
                return View(result.Data);
            }
            else
            {
                return View();
            }
        }

    }
}
