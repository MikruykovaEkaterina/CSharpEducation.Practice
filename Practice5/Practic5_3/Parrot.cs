using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice5_3
{
  internal class Parrot: Animal, IFlyable
  {
    private Color color;
    public Parrot(string name, int age) : base(name, age)
    {
      Console.WriteLine($"Создали попугая с кличкой {name}, возрастом {age}");
    }
    public new void MakeSound()
    {
      Console.WriteLine("Parrot is talking");
    }
    public void MakeSound(string words) 
    {
      Console.WriteLine(words);
    }
    public void Fly()
    {
      Console.WriteLine("Parrot is flying");
    }
  }

}
