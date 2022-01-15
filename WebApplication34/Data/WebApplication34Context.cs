using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication34.Model;

namespace WebApplication34.Data
{
    public class WebApplication34Context : DbContext
    {
        public WebApplication34Context (DbContextOptions<WebApplication34Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication34.Model.Employee> Employee { get; set; }
    }
}
