using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chiricescu_Bianca_Lab2.Models;

namespace Chiricescu_Bianca_Lab2.Data
{
    public class Chiricescu_Bianca_Lab2Context : DbContext
    {
        public Chiricescu_Bianca_Lab2Context (DbContextOptions<Chiricescu_Bianca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Chiricescu_Bianca_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
