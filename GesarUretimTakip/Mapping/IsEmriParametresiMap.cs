using Cores.Entities.Uretim;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class IsEmriParametresiMap : EntityTypeConfiguration<IsEmriParametresi>
    {
        public IsEmriParametresiMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.ParametreTanimi).HasMaxLength(100);
            this.Property(q => q.ParcaKodu).HasMaxLength(100);
            this.Property(q => q.ParcaAdi).HasMaxLength(500);
            this.Property(q => q.Malzeme).HasMaxLength(300);
            this.Property(q => q.Marka).HasMaxLength(300);
            this.Property(q => q.Adet).HasMaxLength(300);

            this.ToTable("IsEmriParametreleri");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.ParametreTanimi).HasColumnName("ParametreTanimi");
            this.Property(q => q.ParcaResmi).HasColumnName("ParcaResmi");
            this.Property(q => q.ParcaKodu).HasColumnName("ParcaKodu");
            this.Property(q => q.ParcaAdi).HasColumnName("ParcaAdi");
            this.Property(q => q.Malzeme).HasColumnName("Malzeme");
            this.Property(q => q.Marka).HasColumnName("Marka");
            this.Property(q => q.Adet).HasColumnName("Adet");
        }
    }
}
