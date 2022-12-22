using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Szilveszter_Levente_Lab2.Models;

namespace Szilveszter_Levente_Lab2.Data
{
    public class Szilveszter_Levente_Lab2Context : DbContext
    {
        public Szilveszter_Levente_Lab2Context (DbContextOptions<Szilveszter_Levente_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Szilveszter_Levente_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Szilveszter_Levente_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Szilveszter_Levente_Lab2.Models.Category> Category { get; set; }

        public DbSet<Szilveszter_Levente_Lab2.Models.Member> Member { get; set; }

        public DbSet<Szilveszter_Levente_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
