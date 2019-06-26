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
        private BarrelRepository repository;

        public BarrelService()
        {
            repository = new BarrelRepository();
        }

        public List<Barrel> GetAllBarrels()
        {
            return repository.GetAllBarrels();
        }

        public Barrel GetBarrelById(int id)
        {
            return repository.GetBarrelById(id);
        }

        public void AddBarrel(Barrel toAdd)
        {
            repository.AddBarrel(toAdd);
        }

        public void SaveEdits(Barrel toSave)
        {
            repository.SaveEdits(toSave);
        }

        public void DeleteBarrel(Barrel toDelete)
        {
            repository.DeleteBarrel(toDelete);
        }

    }
}