using CahitYazilim.Todo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CahitYazilim.Todo.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class AciliyetMap : IEntityTypeConfiguration<Aciliyet>
    {
        public void Configure(EntityTypeBuilder<Aciliyet> builder)
        {
            builder.Property(I => I.Tanim).HasMaxLength(100);
        }
    }
}
