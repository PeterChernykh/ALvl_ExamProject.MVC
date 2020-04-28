﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.BL.Models
{
    public class ProductBL
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public double Price { get; set; }

        public int CategoryBLId { get; set; }
        public CategoryBL CategoryBL { get; set; }
    }
}
