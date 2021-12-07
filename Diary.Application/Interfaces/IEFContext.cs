using Microsoft.EntityFrameworkCore;
using Diary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Application.Interfaces
{
    public interface IEFContext
    {
        DbSet<DiaryPage> Diario { get; set; }
    }
}
