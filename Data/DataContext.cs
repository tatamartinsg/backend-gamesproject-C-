using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using games_api.Models;
using Microsoft.EntityFrameworkCore;


namespace games_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base (options){}

         protected override void OnModelCreating(ModelBuilder modelBuilder){
            
            modelBuilder.Entity<Game>().Navigation(g => g.Images).AutoInclude();
         }
        public DbSet<Game> Game { get; set;}
        public DbSet<Image> ?Image { get; set;}
        
    }
}