using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Diary.Application.Interfaces;
using Diary.Domain.Entities;

namespace Diary.Infrastructure.Context
{
    public class EFContext : DbContext, IEFContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }
        public DbSet<DiaryPage> Diario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
