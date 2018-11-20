using System;
using System.Collections.Generic;
using System.Text;

namespace JournalingAround.Domain.Entities.Journal
{
    public class JournalTag
    {
        public int Id { get; set; }
        public int JournalEntryId { get; set; }
        public JournalEntry JournalEntry { get; set; }
        public string TagName { get; set; }
    }
}
