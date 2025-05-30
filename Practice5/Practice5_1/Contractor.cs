using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_1
{
  internal class Contractor: Employee
  {
    private float HourlyRate;
    public Contractor(string Name, int HourlyRate) : base(Name, Salary: 0)
    {
      this.HourlyRate = HourlyRate;
    }
    public new float CalculateBonus(int hoursWorked) // new? у меня же есть параметры, мне не обязательно 
    {
      return HourlyRate * hoursWorked * 0.15f;
    }
    public new void PrintBonus(int hoursWorked) // new? у меня же есть параметры, мне не обязательно 
    {
      Console.WriteLine($"Зарплата {this.Name} почасовая = {HourlyRate* hoursWorked}, бонус от зарплаты = {this.CalculateBonus(hoursWorked)}");
    }
  }
}
