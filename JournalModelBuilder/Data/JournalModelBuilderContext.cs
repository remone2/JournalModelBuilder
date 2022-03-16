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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Journal>().HasKey(j => j.JournalId);
            builder.Entity<User>().HasKey(u => u.UserId);
            builder.Entity<Journal>().HasMany(e => e.EditorUsers).WithOne(j => j.EditJournal).HasForeignKey(j => j.EditJournalId);
            builder.Entity<Journal>().HasOne(o => o.OwnerUser).WithMany(j => j.OwnJournals).HasForeignKey(j => j.OwnerUserId);
            builder.Entity<Journal>().Property(j => j.Content).HasMaxLength(100);
            builder.Entity<Journal>().HasData(new Journal
            {
                Title="Good Weather",Content="Sun day"
            });
            builder.Entity<User>().HasData(new User
            {
                UserId=1,UserName="Administrator"
            });
        }

        public DbSet<JournalModelBuilder.Models.Journal> Journals { get; set; }
    }
}
