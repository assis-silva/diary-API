using Diary.Domain.Entities;
using Diary.Infrastructure.Mapping.ValueGenerator;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Infrastructure.Mapping
{
    public class DiaryPageMapping : IEntityTypeConfiguration<DiaryPage>
    {
        public void Configure(EntityTypeBuilder<DiaryPage> builder)
        {
            builder.ToTable("TB_DIARIO");

            builder.HasKey(a => a.Id);
            builder.Property<int>(a => a.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd();

            builder.Property<DateTime>(a => a.CreatedAt)
            .ValueGeneratedOnAdd()
            .HasColumnName("CREATED_AT")
            .HasValueGenerator<DateNowGenerator>();

            builder.Property<DateTime>(a => a.UpdatedAt)
            .ValueGeneratedOnAdd()
            .HasColumnName("UPDATED_AT")
            .HasValueGenerator<DateNowGenerator>();

            builder.Property(e => e.Title)
            .HasColumnType("varchar(100)")
            .HasColumnName("TTILE");

            builder.Property(e => e.Body)
            .HasColumnType("varchar(100)")
            .HasColumnName("BODY");
        }
    }
}
