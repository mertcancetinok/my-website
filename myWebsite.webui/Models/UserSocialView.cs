using System.Collections.Generic;
using myWebsite.entity;

namespace myWebsite.webui.Models
{
    public class UserSocialView
    {
        public User user { get; set; }
        public List<SocialMedia> SocialMediae { get; set; }
    }
}