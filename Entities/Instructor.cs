using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1.Entities;

public class Instructor
{
    public Instructor()
    {
        
    }

    public Instructor(int ıd, string name, string ınstructionName)
    {
        Id = ıd;
        Name = name;
        InstructionName = ınstructionName;
       
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string InstructionName { get; set; }

    public Instruction Instruction { get; set; }

}
