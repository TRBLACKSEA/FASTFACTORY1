using Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFactory.Mapping
{
    public class KullaniciMap : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            this.HasKey(q => q.ID);
            this.Property(q => q.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(q => q.KullaniciAdi).HasMaxLength(100);
            this.Property(q => q.Sifre).HasMaxLength(100);
            this.Property(q => q.Mail).HasMaxLength(100);
            this.Property(q => q.Telefon).HasMaxLength(10);

            this.ToTable("Kullanicilar");
            this.Property(q => q.ID).HasColumnName("ID");
            this.Property(q => q.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(q => q.Sifre).HasColumnName("Sifre");
            this.Property(q => q.Mail).HasColumnName("Mail");
            this.Property(q => q.Telefon).HasColumnName("Telefon");

        }
    }
}
