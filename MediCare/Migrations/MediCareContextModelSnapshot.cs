// <auto-generated />
using MediCare.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MediCare.Migrations
{
    [DbContext(typeof(MediCareContext))]
    partial class MediCareContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediCare.Models.OrderMedicine", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");
                    
                    b.Property<string>("Strips")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("OrderMedicine");
                });

            modelBuilder.Entity("MediCare.Models.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MedicineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strips")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");
                                        
                    b.Property<string>("Rate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medicine");
                });

            modelBuilder.Entity("MediCare.Models.ContactUs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");
                    
                    b.HasKey("id");

                    b.ToTable("ContactUs");
                });

            modelBuilder.Entity("MediCare.Models.Medicine", b =>
            {
                b.HasOne("MediCare.Models.OrderMedicine", "medicineId")
                    .WithMany()
                    .HasForeignKey("MedicineId");
            });
#pragma warning restore 612, 618
        }
    }
}
