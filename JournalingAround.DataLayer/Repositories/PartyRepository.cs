using JournalingAround.DataLayer.Entities.Party;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JournalingAround.DataLayer.Repositories
{
    public class PartyRepository : AbstractRepository
    {
        public DbSet<Party> Parties { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Organisation> Organisations { get; set; }
        
    }
}
