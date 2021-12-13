using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Diary.Domain.Entities;

namespace Diary.Application.Interfaces
{
    public interface IEFContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        DbSet<DiaryPage> Pages { get; set; }
    }
}
