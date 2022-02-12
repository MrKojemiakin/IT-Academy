using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApp.Models.Entities

{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int OrderNumber { get; set; }

        

        public List<Variant> Variants { get; set; } = new List<Variant>();


    }
}
