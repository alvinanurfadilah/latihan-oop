using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOOP;

public class Person
{
    public int nip { get; set; }
    public string name;
    public string goWork;
    public int salary;

    public virtual void Introduction()
    {
        Console.WriteLine("NIP : " + nip);
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Go to Work : " + goWork);
        Console.WriteLine("Salary : " + salary);
    }
}