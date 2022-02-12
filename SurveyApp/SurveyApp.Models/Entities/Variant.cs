using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApp.Models.Entities
{
    public class Variant
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public string Letter { get; set; }

        public int QuestionId { get; set; }

        public  Question Question { get; set; }
         


    }
}
