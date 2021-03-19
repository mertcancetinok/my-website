using System.Collections.Generic;
using myWebsite.entity;

namespace myWebsite.webui.Models
{
    public class UserDetailsJobsSkillView
    {
        public UserDetail UserDetail { get; set; }
        public List<Job> Jobs { get; set; }
        public List<Skill> Skills { get; set; }
    }
}