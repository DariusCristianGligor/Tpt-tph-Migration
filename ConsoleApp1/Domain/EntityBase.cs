using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domain
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTimeOffset LastModification { get; set; } 
    }
}
