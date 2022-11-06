using Microsoft.EntityFrameworkCore;

namespace CRUDApplication.Models
{
    public class TransactionDBContext:DbContext
    {
        /** Esto sera usado para la inyeccion de dependencias en un futuro*/
        public TransactionDBContext(DbContextOptions<TransactionDBContext>options):base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
