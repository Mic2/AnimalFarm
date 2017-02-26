using AnimalFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.ViewModels
{
    public interface IRepository<T> where T : IEntity
    {
        IEnumerable<T> List { get; }

        // Making the Classes that implements this Repository interface forced to create Add method.
        void Add(T entity);
    }
}
