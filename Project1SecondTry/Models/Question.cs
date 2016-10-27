using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class Question
    {
        [Table("Question")]
        public String QuestionId { get; set; }
        public int Questions { get; set; }

    }
}