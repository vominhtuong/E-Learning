using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using E_Learning.Models;

namespace E_Learning.Data
{
    public class E_LearningContext : DbContext
    {
        public E_LearningContext (DbContextOptions<E_LearningContext> options)
            : base(options)
        {
        }

        public DbSet<E_Learning.Models.User>? User { get; set; }

        public DbSet<E_Learning.Models.Student>? Student { get; set; }
    }
}
