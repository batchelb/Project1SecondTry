using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1SecondTry.Models
{
    [Table("Response")]
    public class Response
    {
        public int ResponseId { get; set; }
        public string Responses { get; set; }
        public String QuestionId { get; set; }
    }
}