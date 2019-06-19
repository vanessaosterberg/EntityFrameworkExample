using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Models
{
    public class ExampleChildEntity
    {
       [Key]
        public int Id { get; set; }

        public string ExampleData { get; set; }

        public ExampleEntity ParentEntity { get; set; }

        public int ParentEntityId { get; set; }
    }
}