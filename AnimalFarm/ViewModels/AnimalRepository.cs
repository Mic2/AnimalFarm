using AnimalFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.ViewModels
{
    public class AnimalRepository : IRepository<Animal>
    {
        // Setting up the Context that we want to use in this Repository.
        // The context in this study case is our AnimalContext class, that implements DbContext.
        // wich will be able to make CRUD opereations to our AnimalFarm.db database.
        private AnimalContext _animalContext;

        public AnimalRepository()
        {
            _animalContext = new AnimalContext();
        }

        public IEnumerable<Animal> List
        {
            get
            {
                return _animalContext.animals;
            }
        }

        public void Add(Animal entity)
        {
            // Adding the new animal to the animals table.
            _animalContext.animals.Add(entity);

            // Writing the new animal to the animals table.
            _animalContext.SaveChanges();
        }
    }
}
