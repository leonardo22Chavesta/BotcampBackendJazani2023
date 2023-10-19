using Jazani.Domain.Generals.Models;
using Jazani.Infrastructure.Cores.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazani.Infrastructure.Generals.Configurations
{
    public class MineralConfiguration : IEntityTypeConfiguration<Mineral>
    {
        public void Configure(EntityTypeBuilder<Mineral> builder)
        {

            builder.ToTable("mineral", "ge");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MineralTypeId).HasColumnName("mineraltypeid");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.Symbol).HasColumnName("symbol");
            builder.Property(x => x.RegistrationDate)
                .HasColumnName("registrationdate")
                .HasConversion(new DateTimeToDateTimeOffset());
            builder.Property(x => x.State).HasColumnName("state");


            builder.HasOne(one => one.MineralType).WithMany(many => many.Mineral)
                .HasForeignKey(fk => fk.MineralTypeId);

        }
    }
}
