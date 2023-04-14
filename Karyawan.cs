using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP;

public class Karyawan : Person
{
    double allowance;
    public double Total()
    {
        double bpjs = 2/100d;
        return salary - bpjs + allowance;
    }

    public void TotalSalary()
    {
        Console.WriteLine("Total Salary : " + Total());
    }

    public double Total(double allowance)
    {
        double bpjs = 2 / 100d;
        return salary - bpjs + allowance;
    }

    public void TotalSalary(double allowance)
    {
        Console.WriteLine("Total Salary : " + Total(allowance));
    }

    public override void Introduction()
    {
        base.Introduction();
    }
}