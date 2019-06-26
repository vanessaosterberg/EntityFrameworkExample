using EntityFrameworkExample.Data.Context;
using EntityFrameworkExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Repositories
{
    public class BoxRepository
    {
        public DataContext dbContext;

        public BoxRepository()
        {
            dbContext = new DataContext();
        }

        public List<Box> GetAllBoxes()
        {
            return dbContext.Boxes.ToList();
        }

        public void AddBox(Box toAdd)
        {
            dbContext.Boxes.Add(toAdd);
            dbContext.SaveChanges();
        }

        public Box GetBoxById(int id)
        {
            return dbContext.Boxes.Find(id);
        }
    }
}