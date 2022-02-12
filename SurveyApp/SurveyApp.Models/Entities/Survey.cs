using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApp.Models.Entities
{
    public class Survey
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Question> Questions { get; set; } = new List<Question>();

        public List<User> Users { get; set; }=new List<User>();

    }
}
