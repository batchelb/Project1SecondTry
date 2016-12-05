using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1SecondTry.Models
{
    [Table("DegreeQuestions")]
    public class DegreeQuestions
    {
        [Key]
        public int DegreeQuestionID { get; set; }
        public int DegreeID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}