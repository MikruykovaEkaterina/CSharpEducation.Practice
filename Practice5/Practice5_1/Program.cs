using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Practice5_1
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees =
      [
        new Employee("Kate", 30000),
        new Manager("Maria", 30000, 6),
        new Contractor("Egor", 3000),
      ];

      foreach (Employee employee in employees)
      {
        if (employee is Contractor contractor)
        {
          contractor.PrintBonus(100);
          FileLogger.Warning("Проверка работы");
        }
        else
        {
          employee.PrintBonus();
        }
      }
    }
  }
}