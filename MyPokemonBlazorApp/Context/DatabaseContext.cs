using Microsoft.EntityFrameworkCore;
using MyPokemonBlazorApp.Model;

namespace MyPokemonBlazorApp.Context
{
    public class DatabaseContext : DbContext
    {

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbpath = @"C:\Users\User\Desktop\Pokemon Proj Full\Pokemon DB Stuff\pokemon.db";
            optionsBuilder.UseSqlite($"Data Source = {dbpath}");
        }
    }
}
