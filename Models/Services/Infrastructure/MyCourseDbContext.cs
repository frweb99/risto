using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RCommerce.Models.Entities;

namespace RCommerce.Models.Services.Infrastructure
{
    public partial class MyCourseDbContext : DbContext
    {
        public MyCourseDbContext()
        {
        }

        public MyCourseDbContext(DbContextOptions<MyCourseDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Dispositivi> Dispositivi { get; set; }
        public virtual DbSet<Immagini> Immagini { get; set; }
        public virtual DbSet<Ingredienticloud> Ingredienticloud { get; set; }
        public virtual DbSet<Ingredientiprodotti> Ingredientiprodotti { get; set; }
        public virtual DbSet<Licenze> Licenze { get; set; }
        public virtual DbSet<Lingue> Lingue { get; set; }
        public virtual DbSet<Negozi> Negozi { get; set; }
        public virtual DbSet<Ordini> Ordini { get; set; }
        public virtual DbSet<Ordiniprodotti> Ordiniprodotti { get; set; }
        public virtual DbSet<Prodotti> Prodotti { get; set; }
        public virtual DbSet<Qrgenerator> Qrgenerator { get; set; }
        public virtual DbSet<Sessioni> Sessioni { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Utenti> Utenti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Data Source=localhost; Database=ghiot; User ID=root; Password=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.HasKey(e => e.Idcategoria);

                entity.ToTable("categorie");

                entity.Property(e => e.Idcategoria)
                    .HasColumnName("idcategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Immagine)
                    .IsRequired()
                    .HasColumnName("immagine")
                    .HasColumnType("text");

                entity.Property(e => e.Nomecategoria)
                    .IsRequired()
                    .HasColumnName("nomecategoria")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Dispositivi>(entity =>
            {
                entity.HasKey(e => e.Iddispositivo);

                entity.ToTable("dispositivi");

                entity.Property(e => e.Iddispositivo)
                    .HasColumnName("iddispositivo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Codiceautorizzazione)
                    .IsRequired()
                    .HasColumnName("codiceautorizzazione")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Lingua)
                    .IsRequired()
                    .HasColumnName("lingua")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'italiano'");

                entity.Property(e => e.Nominativo)
                    .IsRequired()
                    .HasColumnName("nominativo")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Numerodispositivo)
                    .HasColumnName("numerodispositivo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numeroprodotti)
                    .HasColumnName("numeroprodotti")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.Pagamento)
                    .IsRequired()
                    .HasColumnName("pagamento")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'anticipato'");

                entity.Property(e => e.Tipologia)
                    .IsRequired()
                    .HasColumnName("tipologia")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'kiosk'");
            });

            modelBuilder.Entity<Immagini>(entity =>
            {
                entity.HasKey(e => e.Idimmagine);

                entity.ToTable("immagini");

                entity.Property(e => e.Idimmagine)
                    .HasColumnName("idimmagine")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Idutente)
                    .HasColumnName("idutente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasColumnName("link")
                    .HasColumnType("text");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Ingredienticloud>(entity =>
            {
                entity.HasKey(e => e.Idingrediente);

                entity.ToTable("ingredienticloud");

                entity.Property(e => e.Idingrediente)
                    .HasColumnName("idingrediente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Allergeni)
                    .HasColumnName("allergeni")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Surgelatofresco)
                    .HasColumnName("surgelatofresco")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Ingredientiprodotti>(entity =>
            {
                entity.HasKey(e => e.Idingrediente);

                entity.ToTable("ingredientiprodotti");

                entity.Property(e => e.Idingrediente)
                    .HasColumnName("idingrediente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Allergeni)
                    .HasColumnName("allergeni")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Idcategoria)
                    .HasColumnName("idcategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idprodotto)
                    .HasColumnName("idprodotto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("text");

                entity.Property(e => e.Surgelatofresco)
                    .HasColumnName("surgelatofresco")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Licenze>(entity =>
            {
                entity.HasKey(e => e.Idlicenza);

                entity.ToTable("licenze");

                entity.Property(e => e.Idlicenza)
                    .HasColumnName("idlicenza")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Consegnata)
                    .HasColumnName("consegnata")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Durata)
                    .HasColumnName("durata")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'30'");

                entity.Property(e => e.Iddealer)
                    .HasColumnName("iddealer")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasColumnName("serial")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Sitoweb)
                    .HasColumnName("sitoweb")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Supportotecnico)
                    .HasColumnName("supportotecnico")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Sviluppatore)
                    .HasColumnName("sviluppatore")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Utilizzata)
                    .HasColumnName("utilizzata")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Lingue>(entity =>
            {
                entity.HasKey(e => e.IdLingua);

                entity.ToTable("lingue");

                entity.Property(e => e.IdLingua)
                    .HasColumnName("idLingua")
                    .HasColumnType("int(11)");

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnName("file")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Negozi>(entity =>
            {
                entity.HasKey(e => e.Idnegozio);

                entity.ToTable("negozi");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dataattivazione)
                    .HasColumnName("dataattivazione")
                    .HasColumnType("date");

                entity.Property(e => e.Datascadenza)
                    .HasColumnName("datascadenza")
                    .HasColumnType("date");

                entity.Property(e => e.Emailpaypal)
                    .IsRequired()
                    .HasColumnName("emailpaypal")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Imagelogo)
                    .IsRequired()
                    .HasColumnName("imagelogo")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("'/image/logo/immaginenodisponibile.gif'");

                entity.Property(e => e.Immagine)
                    .HasColumnName("immagine")
                    .HasColumnType("text");

                entity.Property(e => e.Nomenegozio)
                    .IsRequired()
                    .HasColumnName("nomenegozio")
                    .HasColumnType("text");

                entity.Property(e => e.Prodottiquantita)
                    .HasColumnName("prodottiquantita")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'7'");

                entity.Property(e => e.Requestcameriere)
                    .HasColumnName("requestcameriere")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sitoweb)
                    .HasColumnName("sitoweb")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Supportotecnico)
                    .HasColumnName("supportotecnico")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Sviluppatore)
                    .HasColumnName("sviluppatore")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Valuta)
                    .IsRequired()
                    .HasColumnName("valuta")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("'€'");

                entity.Property(e => e.Versione)
                    .IsRequired()
                    .HasColumnName("versione")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("'1.0'");
            });

            modelBuilder.Entity<Ordini>(entity =>
            {
                entity.HasKey(e => e.Idordine);

                entity.ToTable("ordini");

                entity.Property(e => e.Idordine)
                    .HasColumnName("idordine")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("date");

                entity.Property(e => e.Iddispositivo)
                    .HasColumnName("iddispositivo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Letto)
                    .HasColumnName("letto")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Numerodispositivo)
                    .HasColumnName("numerodispositivo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ordinecompleto)
                    .HasColumnName("ordinecompleto")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ordineconfermato)
                    .HasColumnName("ordineconfermato")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ordinecucina)
                    .HasColumnName("ordinecucina")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ordinepagato)
                    .HasColumnName("ordinepagato")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Passatosusmartphone)
                    .HasColumnName("passatosusmartphone")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Richiestapassaggiosmartphone)
                    .HasColumnName("richiestapassaggiosmartphone")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Totaleprezzo)
                    .HasColumnName("totaleprezzo")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Ordiniprodotti>(entity =>
            {
                entity.HasKey(e => e.Idordineprodotti);

                entity.ToTable("ordiniprodotti");

                entity.Property(e => e.Idordineprodotti)
                    .HasColumnName("idordineprodotti")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Completato)
                    .HasColumnName("completato")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idordine)
                    .HasColumnName("idordine")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idprodotto)
                    .HasColumnName("idprodotto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Ingredientinondesiderati)
                    .IsRequired()
                    .HasColumnName("ingredientinondesiderati")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Nomeprodotto)
                    .IsRequired()
                    .HasColumnName("nomeprodotto")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Quantita)
                    .HasColumnName("quantita")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<Prodotti>(entity =>
            {
                entity.HasKey(e => e.Idprodotto);

                entity.ToTable("prodotti");

                entity.Property(e => e.Idprodotto)
                    .HasColumnName("idprodotto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Allergeni)
                    .HasColumnName("allergeni")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Calorie)
                    .HasColumnName("calorie")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Frescosurgelato)
                    .IsRequired()
                    .HasColumnName("frescosurgelato")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'no'");

                entity.Property(e => e.Idcategoria)
                    .HasColumnName("idcategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Immagine)
                    .IsRequired()
                    .HasColumnName("immagine")
                    .HasColumnType("text");

                entity.Property(e => e.Inofferta)
                    .HasColumnName("inofferta")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nascosto)
                    .HasColumnName("nascosto")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Nomeprodotto)
                    .IsRequired()
                    .HasColumnName("nomeprodotto")
                    .HasColumnType("text");

                entity.Property(e => e.Prezzo)
                    .HasColumnName("prezzo")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Video)
                    .HasColumnName("video")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<Qrgenerator>(entity =>
            {
                entity.ToTable("qrgenerator");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descrizione)
                    .IsRequired()
                    .HasColumnName("descrizione")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Iddispositivo)
                    .HasColumnName("iddispositivo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Numerodispositivo)
                    .HasColumnName("numerodispositivo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Titolo)
                    .IsRequired()
                    .HasColumnName("titolo")
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Sessioni>(entity =>
            {
                entity.HasKey(e => e.Idsessione);

                entity.ToTable("sessioni");

                entity.Property(e => e.Idsessione)
                    .HasColumnName("idsessione")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iddispositivolingua)
                    .HasColumnName("iddispositivolingua")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Lingua)
                    .IsRequired()
                    .HasColumnName("lingua")
                    .HasColumnType("varchar(500)")
                    .HasDefaultValueSql("'italiano'");

                entity.Property(e => e.New)
                    .IsRequired()
                    .HasColumnName("new")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token")
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.ToTable("settings");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Actionpaypal)
                    .HasColumnName("actionpaypal")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Emailpaypal)
                    .HasColumnName("emailpaypal")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Idcategoriapredefinita)
                    .HasColumnName("idcategoriapredefinita")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Imagelogo)
                    .IsRequired()
                    .HasColumnName("imagelogo")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Prodottiquantita)
                    .HasColumnName("prodottiquantita")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'10'");

                entity.Property(e => e.Requestcameriere)
                    .HasColumnName("requestcameriere")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasColumnName("serial")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Sitoweb)
                    .IsRequired()
                    .HasColumnName("sitoweb")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Sitowebsoftware)
                    .IsRequired()
                    .HasColumnName("sitowebsoftware")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Supportotecnico)
                    .IsRequired()
                    .HasColumnName("supportotecnico")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Sviluppatore)
                    .IsRequired()
                    .HasColumnName("sviluppatore")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Valuta)
                    .IsRequired()
                    .HasColumnName("valuta")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Utenti>(entity =>
            {
                entity.HasKey(e => e.Idutente);

                entity.ToTable("utenti");

                entity.Property(e => e.Idutente)
                    .HasColumnName("idutente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cap)
                    .IsRequired()
                    .HasColumnName("cap")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Citta)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Codiceelettronico)
                    .HasColumnName("codiceelettronico")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Cognome)
                    .IsRequired()
                    .HasColumnName("cognome")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Dealer)
                    .HasColumnName("dealer")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Emailpaypal)
                    .IsRequired()
                    .HasColumnName("emailpaypal")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Iddealer)
                    .HasColumnName("iddealer")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Idnegozio)
                    .HasColumnName("idnegozio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Indirizzo)
                    .IsRequired()
                    .HasColumnName("indirizzo")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasColumnName("logo")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Numerocivico)
                    .IsRequired()
                    .HasColumnName("numerocivico")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Partitaiva)
                    .HasColumnName("partitaiva")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Ragionesociale)
                    .IsRequired()
                    .HasColumnName("ragionesociale")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'7'");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasColumnType("varchar(500)");
            });
        }
    }
}
