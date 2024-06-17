using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET_MVC.Models;

namespace ASP_NET_MVC.Data
{
    public class ASP_NET_MVCContext1 : DbContext
    {
        public ASP_NET_MVCContext1 (DbContextOptions<ASP_NET_MVCContext1> options)
            : base(options)
        {
        }

        public DbSet<ASP_NET_MVC.Models.Movie> Movie { get; set; } = default!;
    }
}
