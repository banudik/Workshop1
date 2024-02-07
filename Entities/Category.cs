using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop1.Entities;

public class Category
{
    public Category()
    {
        
    }

    public Category(int ıd, string name)
    {
        Id = ıd;
        Name = name;
      
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public List<Instruction> Instructions { get; set; }
}
