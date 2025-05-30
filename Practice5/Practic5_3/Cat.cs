using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_3
{
  internal class Cat: Animal
  {
    public Cat(string name, int age) : base(name, age) 
    {
      Console.WriteLine($"Создали кошку с кличкой {name}, возрастом {age}");
    }
    public override void MakeSound()
    {
      Console.WriteLine("Meow!");
    }
  }
}
