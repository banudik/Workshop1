using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1.Entities;

public class Instruction
{
    public Instruction()
    {
        
    }

    public Instruction(int ıd, string name, string description, string ınstructorName, string price)
    {
        Id = ıd;
        Name = name;
        Description = description;
        InstructorName = ınstructorName;
        Price = price;
        
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string InstructorName { get; set; }
    public string Price { get; set; }

    public Category Category { get; set; }

}
