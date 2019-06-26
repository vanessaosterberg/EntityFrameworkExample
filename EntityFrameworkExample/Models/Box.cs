using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Models
{
    public class Box
    {
        [Key]
        public int Id { get; set; }
        public double width { get; set; }
        public double height { get; set; }
    }
}