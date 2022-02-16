using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Digital_Pocket_Monster.Models;

namespace Digital_Pocket_Monster.Data
{
    public class DigimonContext : DbContext
    {
        public DigimonContext(DbContextOptions options) : base(options)
        {

        }

        // Will create the tables in the database using the models
        public DbSet<AccountInfo> AccountInfo { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Deck> Decks { get; set; }
        public DbSet<Pack> Packs { get; set; }
    }
}
