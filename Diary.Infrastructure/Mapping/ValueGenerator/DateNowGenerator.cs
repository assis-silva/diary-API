using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Infrastructure.Mapping.ValueGenerator
{
    class DateNowGenerator : ValueGenerator<DateTime>
    {
        public override bool GeneratesTemporaryValues { get; }

        public override DateTime Next([NotNullAttribute] EntityEntry entry)
        {
              return DateTime.Now;
        }
    }
}
