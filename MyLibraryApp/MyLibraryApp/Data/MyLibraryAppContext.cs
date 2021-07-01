using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyLibraryApp.Models;

namespace MyLibraryApp.Data
{
    public class MyLibraryAppContext : DbContext
    {
        public MyLibraryAppContext (DbContextOptions<MyLibraryAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyLibraryApp.Models.Books> Books { get; set; }
    }
}
