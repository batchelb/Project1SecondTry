using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project1SecondTry.Models
{
    [Table("Degrees")]
    public class Degrees
    {
        [Key]
        public int DegreeID { get; set; }
        public string DegreeName { get; set; }
        public string DegreeCoordinator { get; set; }
        public string CoordinatorTitle { get; set; }
        public string CoordinatorOfficeAddress { get; set; }
        public string PhdEducation { get; set; }
        public string MastersEducation { get; set; }
        public string BachelorsEducation { get; set; }
        public string CoordinatorPicture { get; set; }
    }
}