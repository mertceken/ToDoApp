using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20201031_ToDo.Models
{
    public class TaskListContext : DbContext
    {
        public  TaskListContext(DbContextOptions<TaskListContext> options) : base(options)
        { }

        public DbSet<TaskList> TaskList { get; set; }
    }
}
