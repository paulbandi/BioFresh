// <auto-generated />
using System;
using BioFresh.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BioFresh.Migrations
{
    [DbContext(typeof(BioFreshContext))]
    [Migration("20210613222409_Comenzi")]
    partial class Comenzi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BioFresh.Models.Client", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Locatia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("BioFresh.Models.Comanda", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DateDeContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PretTotal")
                        .HasColumnType("float");

                    b.Property<int>("TimpDeLivrare")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Comanda");
                });

            modelBuilder.Entity("BioFresh.Models.Livrare", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LivrareComanda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RidicareComanda")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Livrare");
                });

            modelBuilder.Entity("BioFresh.Models.Meniu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Calorii")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pret")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Meniu");
                });

            modelBuilder.Entity("BioFresh.Models.Status", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Livrata")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preparata")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
