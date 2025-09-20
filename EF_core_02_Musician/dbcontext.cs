using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Musician
{
    internal class dbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=.;Database=new_Musician_02;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Album>()
            .HasOne(a => a.musician)
            .WithMany(m => m.albums)
            .HasForeignKey(a => a.musician_id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);


            //////////////////////////////////////
            modelBuilder.Entity<Musician_Instruments>()
        .HasKey(mi => new { mi.Musician_Id, mi.Instrument_Id });

            modelBuilder.Entity<Musician_Instruments>()
                .HasOne(mi => mi.Musician)
                .WithMany(m => m.MusicianInstruments)
                .HasForeignKey(mi => mi.Musician_Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Musician_Instruments>()
                .HasOne(mi => mi.Instrument)
                .WithMany(i => i.MusicianInstruments)
                .HasForeignKey(mi => mi.Instrument_Id)
                .OnDelete(DeleteBehavior.Restrict);
            //////////////////////////////////////////
            modelBuilder.Entity<Musician_Songs>()
        .HasKey(ms => new { ms.Musician_Id, ms.Song_Id });

            modelBuilder.Entity<Musician_Songs>()
                .HasOne(ms => ms.Musician)
                .WithMany(m => m.musician_Songs)
                .HasForeignKey(ms => ms.Musician_Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Musician_Songs>()
                .HasOne(ms => ms.Song)
                .WithMany(s => s.musician_Songs)
                .HasForeignKey(ms => ms.Song_Id)
                .OnDelete(DeleteBehavior.Restrict);
            /////////////////////////////////////////
            modelBuilder.Entity<Song>()
                .HasOne(a => a.Album)
                .WithMany(s=>s.Songs)
                .HasForeignKey(a=>a.AlbumId)
                .IsRequired()                          
                .OnDelete(DeleteBehavior.Cascade);



        }

    }
}
