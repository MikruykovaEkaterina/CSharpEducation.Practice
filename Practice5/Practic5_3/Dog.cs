using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_3
{
  internal class Dog: Animal
  {
    public Dog(string name, int age) : base(name, age) 
    {
      Console.WriteLine($"Создали собаку с кличкой {name}, возрастом {age}");
    }

    public override void MakeSound()
    {
      Console.WriteLine("Woof!");
    }
  }
}
