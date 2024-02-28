using Core;
using Core.Entities;
using Cores.Entities;
using Cores.Entities.Depo;
using Cores.Entities.ParameterEntities;
using Cores.Entities.Uretim;
using FastFactory.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesarUretimTakip.Context
{
    
    public class FastFactoryContext : DbContext
    {
        public FastFactoryContext() : base("FastFactoryContext")
        {

        }
        //Ayarlar
        public DbSet<Ayarlar> Ayarlar { get; set; }
        //Üretim Modülü
        public DbSet<TezgahGrubu> TezgahGruplari { get; set; }
        public DbSet<MakineKarti> MakineKartlari { get; set; }
        public DbSet<Takim> Takimlar { get; set; }
        public DbSet<Parca> Parcalar { get; set; }
        public DbSet<OperasyonTanimi> OperasyonTanimlari { get; set; }
        public DbSet<Operasyon> Operasyonlar{ get; set; }

        public DbSet<IsEmriParametresi> IsEmriParametreleri { get; set; }
        public DbSet<Proje> Projeler { get; set; }


        //Depo Modülü
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<DepoTransferFisi> DepoTransferFisleri { get; set; }


        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<SiparisParam> SiparisParametreleri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Ayarlar
            modelBuilder.Configurations.Add(new AyarlarMap());
            //Üretim Modülü
            modelBuilder.Configurations.Add(new TezgahGrubuMap());
            
            modelBuilder.Configurations.Add(new MakineKartiMap());
            modelBuilder.Configurations.Add(new TakimMap());

            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new ParcaMap());
            modelBuilder.Configurations.Add(new OperasyonTanimiMap());
            modelBuilder.Configurations.Add(new OperasyonMap());
            modelBuilder.Configurations.Add(new IsEmriParametresiMap());
            modelBuilder.Configurations.Add(new ProjeMap());

            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new DepoTransferFisiMap());

            modelBuilder.Configurations.Add(new SiparisParamMap());
        }
    }
}
