using Microsoft.AspNetCore.Mvc;
using myWebsite.data.Abstract;
using myWebsite.webui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebsite.webui.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private IUserRepository _userRepository;
        private ISocialRepository _socialRepository;
        public HeaderViewComponent(IUserRepository userRepository, ISocialRepository socialRepository)
        {
            _userRepository = userRepository;
            _socialRepository = socialRepository;
        }
        public IViewComponentResult Invoke()
        {
            UserSocialView userSocialView = new UserSocialView()
            {
                user = _userRepository.GetUser(),
                SocialMediae = _socialRepository.GetAll()
            };
            return View(userSocialView);
        }
    }
}
