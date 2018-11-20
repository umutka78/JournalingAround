using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JournalingAround.Domain.Entities.Journal
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public string Summary { get; set; }
        public string Detail { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private HashSet<JournalTag> _journalTags;
        public IEnumerable<JournalTag> JournalTags => _journalTags?.ToList();
        //private DbContext _context;

        //public JournalEntry(DbContext context)
        //{
        //    _context = context;
        //}

        //public void AddJournalTag(JournalTag journalTag)
        //{

        //    if (_journalTags != null)
        //    {
        //        _journalTags.Add(journalTag);
        //    }
        //    else if (_context == null)
        //    {
        //        throw new ArgumentNullException(nameof(_context),
        //            "You must provide a context if the JournalTags collection isn't valid.");
        //    }
        //    else if (_context.Entry(this).IsKeySet)
        //    {
        //        _context.Add(journalTag);
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("Could not add a new JournalTag.");
        //    }
        //}
    }
}
