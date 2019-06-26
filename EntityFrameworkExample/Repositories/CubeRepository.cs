using EntityFrameworkExample.Data.Context;
using EntityFrameworkExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Repositories
{
    public class CubeRepository
    {
        private DataContext dbContext;

        public CubeRepository()
        {
            dbContext = new DataContext();
        }

        public List<Cube> GetAllCubes()
        {
            return dbContext.Cubes.ToList();
        }

        public Cube GetCubeById(int id)
        {
            return dbContext.Cubes.Find(id);
        }

        public void AddCube(Cube toAdd)
        {
            dbContext.Cubes.Add(toAdd);
            dbContext.SaveChanges();
        }

        public void SaveEdits(Cube toSave)
        {
            dbContext.Entry(toSave).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void DeleteCube(Cube toDelete)
        {
            dbContext.Cubes.Remove(toDelete);
            dbContext.SaveChanges();
        }

    }
}