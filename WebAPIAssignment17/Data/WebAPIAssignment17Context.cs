using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAPIAssignment17.Model;

namespace WebAPIAssignment17.Data
{
    public class WebAPIAssignment17Context : DbContext
    {
        public WebAPIAssignment17Context (DbContextOptions<WebAPIAssignment17Context> options)
            : base(options)
        {
        }

        public DbSet<WebAPIAssignment17.Model.Movie> Movie { get; set; } = default!;
    }
}
