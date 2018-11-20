using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace JournalingAround.DataLayer.Repositories
{
    public abstract class AbstractRepository : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-ALH6PD5; Database=JournalingAround; Trusted_Connection = True;"
                );
        }
    }
}
