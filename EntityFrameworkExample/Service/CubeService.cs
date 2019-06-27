using EntityFrameworkExample.Models;
using EntityFrameworkExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Service
{
    public class CubeService
    {
        private CubeRepository repository;

        public CubeService()
        {
            repository = new CubeRepository();
        }

        public List<Cube> GetAllCubes()
        {
            return repository.GetAllCubes();
        }

        public Cube GetCubeById(int id)
        {
            return repository.GetCubeById(id);
        }

        public void AddCube(Cube toAdd)
        {
            repository.AddCube(toAdd);
        }

        public void SaveEdits(Cube toSave)
        {
            repository.SaveEdits(toSave);
        }

        public void DeleteCube(Cube toDelete)
        {
            repository.DeleteCube(toDelete);
        }

        public int TotalNumberOfCubes()
        {
            return repository.GetAllCubes().Count;
        }
    }
}