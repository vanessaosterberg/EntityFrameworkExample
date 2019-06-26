﻿using EntityFrameworkExample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Data.Configurations
{
    public class BoxConfiguration:EntityTypeConfiguration<Box>
    {
        public BoxConfiguration()
        {
            HasKey(b => b.Id);
        }
    }
}