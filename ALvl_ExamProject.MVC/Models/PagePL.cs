using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ALvl_ExamProject.MVC.Models
{
    public class PagePL
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Title { get; set; }

        public string Slug { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 10)]
        public string Body { get; set; }

        public int Sorting { get; set; }

        public bool Sidebar { get; set; }
    }
}