using Microsoft.EntityFrameworkCore;

namespace ByteBank.Data
{
    public class ByteBankContext : DbContext
    {
        public ByteBankContext(DbContextOptions options)
            :base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=localhost,1435;User ID=sa;Password=1q2w3e4r;Trust Server Certificate=true");
        }
    }
}
