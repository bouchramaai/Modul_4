using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProject.Data.Entities
{
    public class TodoEntity
    {
        public Guid Id { get; set; }
        public  string? Titel {get;set;}
        public string? Description { get; set; }

        public  string? DueDate { get; set; }
        
        public  bool  IsDone { get; set; }

        public UserEntity User { get; set; }
    }
}
