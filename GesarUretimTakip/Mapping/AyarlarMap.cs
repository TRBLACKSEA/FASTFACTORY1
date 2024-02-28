using Cores.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class AyarlarMap :EntityTypeConfiguration<Ayarlar>
    {
        public AyarlarMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.ToTable("Ayarlar");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.VarsayılanIsEmriParametresi).HasColumnName("VarsayılanIsEmriParametresi");

        }
    }
}
