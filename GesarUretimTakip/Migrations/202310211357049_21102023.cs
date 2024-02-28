namespace GesarUretimTakip.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _21102023 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ayarlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        VarsayılanIsEmriParametresi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Depolar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepoKodu = c.String(maxLength: 300),
                        DepoAdi = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Depo Transfer Fisleri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NeredenID = c.Int(nullable: false),
                        NereyeID = c.Int(nullable: false),
                        TransferEdenKullaniciID = c.Int(nullable: false),
                        TransferTarihi = c.DateTime(nullable: false),
                        TransferSaati = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.IsEmriParametreleri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ParametreTanimi = c.String(maxLength: 100),
                        ParcaResmi = c.String(),
                        ParcaKodu = c.String(maxLength: 100),
                        ParcaAdi = c.String(maxLength: 500),
                        Malzeme = c.String(maxLength: 300),
                        Marka = c.String(maxLength: 300),
                        Adet = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Kullanicilar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(maxLength: 100),
                        Sifre = c.String(maxLength: 100),
                        Mail = c.String(maxLength: 100),
                        Telefon = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MakineKartlari",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Kodu = c.String(maxLength: 30),
                        IP = c.String(),
                        MakineAdi = c.String(maxLength: 100),
                        Markasi = c.String(maxLength: 50),
                        Modeli = c.String(maxLength: 50),
                        TezgahGrupID = c.Int(nullable: false),
                        KontrolUnitesi = c.String(maxLength: 50),
                        PortName = c.String(maxLength: 30),
                        BaundRate = c.Int(nullable: false),
                        Priority = c.Decimal(nullable: false, precision: 6, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Operasyonlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OperasyonAdi = c.String(maxLength: 300),
                        OperasyonTanimID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OperasyonTanimlari",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Parcalar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProjeID = c.Int(nullable: false),
                        ParcaResmi = c.Binary(),
                        ParcaKodu = c.String(maxLength: 50),
                        ParcaAdi = c.String(maxLength: 300),
                        Malzeme = c.String(maxLength: 300),
                        Marka = c.String(maxLength: 300),
                        Adet = c.Int(nullable: false),
                        UretilenAdet = c.Int(nullable: false),
                        Durum = c.Int(nullable: false),
                        ParcaDepoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Projeler",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProjeKodu = c.String(maxLength: 30),
                        ProjeAdi = c.String(maxLength: 300),
                        Aciklama = c.String(maxLength: 500),
                        Durum = c.Int(nullable: false),
                        DurumAciklamasi = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SiparisParametreleri",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Desc = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Takimlar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TakimNumarasi = c.String(maxLength: 30),
                        Adi = c.String(maxLength: 30),
                        Markasi = c.String(maxLength: 30),
                        Modeli = c.String(maxLength: 30),
                        UcSayisi = c.Int(nullable: false),
                        UcOmru = c.Decimal(nullable: false, precision: 8, scale: 2),
                        Aciklama = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TezgahGruplari",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TezgahGrupKodu = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TezgahGruplari");
            DropTable("dbo.Takimlar");
            DropTable("dbo.SiparisParametreleri");
            DropTable("dbo.Projeler");
            DropTable("dbo.Parcalar");
            DropTable("dbo.OperasyonTanimlari");
            DropTable("dbo.Operasyonlar");
            DropTable("dbo.MakineKartlari");
            DropTable("dbo.Kullanicilar");
            DropTable("dbo.IsEmriParametreleri");
            DropTable("dbo.Depo Transfer Fisleri");
            DropTable("dbo.Depolar");
            DropTable("dbo.Ayarlar");
        }
    }
}
