using Practice5_3;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_1
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Animal> animals =
      [
        new Cat("Муся", 2),
        new Dog("Бубусик", 3),
        new Parrot("Павлик", 1)
      ];
      foreach (Animal animal in animals) 
      {
        
        if(animal is Parrot parrot)
        {
          parrot.MakeSound();
          parrot.MakeSound("Ауууууу");
        }
        else
        {
          animal.MakeSound();
        }
      }
      IFlyable[] flyables = { animals[2] as Parrot, new Eagle()};
      foreach (IFlyable flyable in flyables)
      {
        flyable.Fly();
      }
    }
  }
}