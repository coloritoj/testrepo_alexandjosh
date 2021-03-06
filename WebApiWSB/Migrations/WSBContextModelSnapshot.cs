// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiWSB.Models;

namespace WebApiWSB.Migrations
{
    [DbContext(typeof(WSBContext))]
    partial class WSBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiWSB.Models.WSB_API_OBJECT", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("no_of_comments")
                        .HasColumnType("int");

                    b.Property<string>("sentiment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("sentiment_score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ticker")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("wsbObjects");
                });
#pragma warning restore 612, 618
        }
    }
}
