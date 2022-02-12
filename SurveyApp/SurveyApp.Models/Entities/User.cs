using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApp.Models.Entities
{
    // 
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public List<Survey> Surveys { get; set; }=new List<Survey>();


    }
}
