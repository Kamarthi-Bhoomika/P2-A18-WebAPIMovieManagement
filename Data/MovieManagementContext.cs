using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiManagement.Models;

namespace WebApiManagement.Data
{
    public class MovieManagementContext : DbContext
    {
        public MovieManagementContext (DbContextOptions<MovieManagementContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiManagement.Models.Movie> Movie { get; set; } = default!;
    }
}
