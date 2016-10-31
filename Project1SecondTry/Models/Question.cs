using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1SecondTry.Models
{
    [Table("Question")]
    public class Question
    {
        
        public int QuestionId { get; set; }
        public String Questions { get; set; }

    }
}