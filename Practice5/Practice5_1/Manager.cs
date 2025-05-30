using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5_1
{
  internal class Manager: Employee
  {
    private int TeamSize;
    public Manager(string Name, float Salary, int TeamSize) : base(Name, Salary) 
    {
      this.TeamSize = TeamSize;
    }
    public override float CalculateBonus()
    {
      if(TeamSize > 5) 
      { 
        return Salary * 0.2f + Salary*0.05f;
      }
      return Salary * 0.2f;
    }
  }
}
