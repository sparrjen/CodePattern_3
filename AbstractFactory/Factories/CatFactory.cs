using Assignment2.AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.AbstractFactory.Factories
{
    public class CatFactory : IFactory
    {
        public IAnimal CreateAnimal(string name)
        {
            return new Cat(name);
        }
    }
}
