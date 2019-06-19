using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Models
{
    public class ExampleEntity
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        public string ExampleStringData { get; set; }

        public int ExampleIntegerData { get; set; }

        //We can tie many ExampleChildEntities to this entity
        public List<ExampleChildEntity> ExampleChildEntities { get; set; }
    }
}