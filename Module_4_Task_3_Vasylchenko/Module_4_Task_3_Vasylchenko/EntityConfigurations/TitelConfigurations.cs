using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module_4_Task_3_Vasylchenko.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_Task_3_Vasylchenko.EntityConfigurations
{
    public class TitelConfigurations : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("TitleId");
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(50);

            builder.HasData(new List<Title>()
            {
                new Title() {Id = 1, Name = "Google"},
                new Title() {Id = 2, Name = "Microsoft"}
            });
        }
    }
}
