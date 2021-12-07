using Diary.Application.Interfaces;
using Diary.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Infrastructure.Context
{
    public class EFContext : DbContext, IEFContext
    {
        public DbSet<DiaryPage> Diario { get; set; }
    }
}
