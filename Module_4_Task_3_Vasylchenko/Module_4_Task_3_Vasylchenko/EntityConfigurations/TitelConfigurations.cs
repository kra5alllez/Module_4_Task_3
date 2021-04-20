using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module_4_Task_3_Vasylchenko.Entities;

namespace Module_4_Task_3_Vasylchenko.EntityConfigurations
{
    public class TitelConfigurations : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnName("TitleId");
            builder.Property(p => p.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
        }
    }
}
