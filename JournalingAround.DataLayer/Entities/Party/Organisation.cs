using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JournalingAround.DataLayer.Entities.Party
{
    public class Organisation
    {
        [ForeignKey(nameof(Party))]
        public int Id { get; set; }
        public Party Party { get; set; }
        public string OrganisationName { get; set; }
        public string TaxId { get; set; }
    }
}
