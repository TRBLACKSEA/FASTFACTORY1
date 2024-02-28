using Cores.Entities.Uretim;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class ProjeMap : EntityTypeConfiguration<Proje>
    {
        public ProjeMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.ProjeKodu).HasMaxLength(30);
            this.Property(q => q.ProjeAdi).HasMaxLength(300);
            this.Property(q => q.Aciklama).HasMaxLength(500);
            this.Property(q => q.DurumAciklamasi).HasMaxLength(30);

            this.ToTable("Projeler");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.ProjeKodu).HasColumnName("ProjeKodu");
            this.Property(q => q.ProjeAdi).HasColumnName("ProjeAdi");
            this.Property(q => q.Aciklama).HasColumnName("Aciklama");
            this.Property(q => q.Durum).HasColumnName("Durum");
            this.Property(q => q.DurumAciklamasi).HasColumnName("DurumAciklamasi");
        }
    }
}
