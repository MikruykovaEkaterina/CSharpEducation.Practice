using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_1
{
  internal class Employee
  {
    protected string Name;
    protected float Salary;
    public virtual float CalculateBonus()
    {
      return Salary * 0.1f;
    }
    public Employee(string Name, float Salary) 
    {
      this.Name = Name;
      this.Salary = Salary;
    }
    public void PrintBonus() 
    {
      Console.WriteLine($"Зарплата {this.Name} = {this.Salary}, бонус от зарплаты = {this.CalculateBonus()}");
    }
  }
}
