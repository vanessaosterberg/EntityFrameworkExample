using EntityFrameworkExample.Models;
using EntityFrameworkExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Service
{
    public class BarrelService
    {
        public BarrelRepository repository;

        public BarrelService()
        {
            repository = new BarrelRepository();
        }

        public List<Barrel> GetAllBarrels()
        {
            return repository.GetAllBarrels();
        }

        public void AddBarrel(Barrel toAdd)
        {
            repository.AddBarrel(toAdd);
        }

    }
}