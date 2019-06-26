using EntityFrameworkExample.Models;
using EntityFrameworkExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Service
{
    public class BoxService
    {
        private BoxRepository repository;

        public BoxService()
        {
            repository = new BoxRepository();
        }

        public List<Box> GetAllBoxes()
        {
            return repository.GetAllBoxes();
        }

        public void AddBox(Box toAdd)
        {
            repository.AddBox(toAdd);
        }
    }
}