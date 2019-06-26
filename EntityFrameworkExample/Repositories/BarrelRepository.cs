using EntityFrameworkExample.Data.Context;
using EntityFrameworkExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Repositories
{
    public class BarrelRepository
    {
        public DataContext dbContext;

        public BarrelRepository()
        {
            dbContext = new DataContext();
        }

        public List<Barrel> GetAllBarrels()
        {
            return dbContext.Barrels.ToList();
        }

        public void AddBarrel(Barrel toAdd)
        {
            dbContext.Barrels.Add(toAdd);
            dbContext.SaveChanges();
        }

        public Barrel GetBarrelById(int id)
        {
            return dbContext.Barrels.Find(id);
        }

        public void SaveEdits(Barrel toSave)
        {
            dbContext.Entry(toSave).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteBarrel(Barrel toDelete)
        {
            dbContext.Barrels.Remove(toDelete);
            dbContext.SaveChanges();
        }



    }
}