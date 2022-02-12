using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApp.Models.Entities
{
    public class Answer
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int QuestionId { get; set; }

        


        public User User { get; set; }

        public Question Question { get; set; }

        


    }
}
