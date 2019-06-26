﻿using EntityFrameworkExample.Models;
using System.Data.Entity.ModelConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Data.Configurations
{
    public class CubeConfiguration: EntityTypeConfiguration<Cube>
    {
        public CubeConfiguration()
        {
            HasKey(b => b.Id);
        }
    }
}