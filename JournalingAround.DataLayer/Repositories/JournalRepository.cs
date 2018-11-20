using JournalingAround.Domain.Entities.Journal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JournalingAround.DataLayer.Repositories
{
    public class JournalRepository : AbstractRepository
    {
        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<JournalTag> JournalTags { get; set; }

    }
}
