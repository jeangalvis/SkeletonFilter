using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence;
public class VeterinaryContext : DbContext
{
    public VeterinaryContext(DbContextOptions<VeterinaryContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // modelBuilder.Entity<Empleado>() inicia en quien no tiene el id
        // .HasOne<Usuario>(p => p.Usuario)
        // .WithOne(ad => ad.Empleado)
        // .HasForeignKey<Usuario>(ad => ad.IdEmpleadofk);
    }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Breed> Breeds { get; set; }
    public DbSet<MedicalTreatment> MedicalTreatments { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<PurchasedMedicine> purchasedMedicines { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Rol> Rols { get; set; }
    public DbSet<SoldMedicine> SoldMedicines { get; set; }
    public DbSet<Species> Species { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRol> UserRols { get; set; }
    public DbSet<Veterinarian> Veterinarians { get; set; }
}
