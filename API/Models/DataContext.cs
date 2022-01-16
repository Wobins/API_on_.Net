using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace API.Models
{
    public class DataContext : DbContext
    {
        //On configure notre base de donnees
        //La classe Iconfiguration permet de maipuler le fichier de configuration appsettings.json
        protected readonly IConfiguration _Configuration;
        public DataContext(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseMySql( _Configuration.GetConnectionString("dataAccess") );
        }

        //Ici on referencie les classes qui seront nos tables, car toutes les classes ne le sont pas forcement
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
