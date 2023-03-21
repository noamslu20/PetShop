using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop;
using PetShop.Models;


namespace PetShop.Repositories
{
    public interface IRepository 
    {
        IEnumerable<Animal> GetAnimals();
        Animal GetAnimalById(int id);
        void InsertAnimal(Animal animal);
        void SaveComment();
        void UpdateAnimal(int id, Animal animal);
        void DeleteAnimal(int id);
        string GetAnimalCategoty(int categoryId);
        IEnumerable<Category> GetCategories();
    }
}
