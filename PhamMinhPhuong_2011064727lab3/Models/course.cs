using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhamMinhPhuong_2011064727lab3.Models
{
    public class course
    {
        
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [StringLength (255)]
        public string Place { get; set; }
        public string DateTime { get; set; }
        public string Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
    }
   
}