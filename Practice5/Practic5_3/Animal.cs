using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_3
{
  internal class Animal
  {
    private string Name;
    private int Age;

    public Animal(string name, int age)
    {
      this.Name = name;
      this.Age = age;
    }

    public void Eat()
    {
      Console.WriteLine("Animal is eating");
    }
    public void Sleep()
    {
      Console.WriteLine("Animal is sleeping");
    }
    virtual public void MakeSound()
    {
      Console.WriteLine("Some generic animal sound");
    }
  }
}
