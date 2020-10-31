using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _20201031_ToDo.Models
{
    public class TaskList
    {
        [Key]
        public int Id { get; set; }

        public string TaskName { get; set; }
    }
}
