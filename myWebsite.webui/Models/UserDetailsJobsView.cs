using System.Collections.Generic;
using myWebsite.entity;

namespace myWebsite.webui.Models
{
    public class UserDetailsJobsView
    {
        public UserDetail UserDetail { get; set; }
        public List<Job> Jobs { get; set; }
    }
}