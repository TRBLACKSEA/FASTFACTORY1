using Cores.Entities.ParameterEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class SiparisParamMap : EntityTypeConfiguration<SiparisParam>
    {
        public SiparisParamMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.Desc).HasMaxLength(50);

            this.ToTable("SiparisParametreleri");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.Desc).HasColumnName("Desc");
        }
    }
}
