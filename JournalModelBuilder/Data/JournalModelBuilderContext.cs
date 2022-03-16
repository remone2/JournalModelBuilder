#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JournalModelBuilder.Models;

namespace JournalModelBuilder.Data
{
    public class JournalModelBuilderContext : DbContext
    {
        public JournalModelBuilderContext (DbContextOptions<JournalModelBuilderContext> options)
            : base(options)
        {
        }



        public DbSet<JournalModelBuilder.Models.Journal> Journals { get; set; }
    }
}
