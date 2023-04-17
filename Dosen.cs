using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP;

internal class Dosen : Person
{
    public double Total()
    {
        double bpjs = 1 / 100d;
        return salary - bpjs;
    }

    public void TotalSalary()
    {
        Console.WriteLine("Total Salary : " + Total());
        Console.WriteLine("============================");
    }

    public double Total(double allowance)
    {
        double bpjs = 1 / 100d;
        return salary - bpjs + allowance;
    }

    public void TotalSalary(double allowance)
    {
        Console.WriteLine("Total Salary : " + Total(allowance));
        Console.WriteLine("============================");
    }
}