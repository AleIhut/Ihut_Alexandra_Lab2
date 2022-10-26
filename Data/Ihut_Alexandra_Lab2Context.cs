using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ihut_Alexandra_Lab2.Models;

namespace Ihut_Alexandra_Lab2.Data
{
    public class Ihut_Alexandra_Lab2Context : DbContext
    {
        public Ihut_Alexandra_Lab2Context (DbContextOptions<Ihut_Alexandra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Ihut_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Ihut_Alexandra_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
