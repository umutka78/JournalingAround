using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JournalingAround.DataLayer.Entities.Party
{
    public class Individual
    {
        [ForeignKey(nameof(Party))]
        public int Id { get; set; }
        public Party Party { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
