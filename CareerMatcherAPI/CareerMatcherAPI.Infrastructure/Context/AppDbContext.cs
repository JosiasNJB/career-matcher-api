using Microsoft.EntityFrameworkCore;
using CareerMatcherAPI.Domain.Entities;

namespace CareerMatcherAPI.Infrastructure.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

    public DbSet<Candidato> Candidatos { get; set; }
    public DbSet<Concurso> Concursos { get; set; }
    public DbSet<Profissao> Profissoes { get; set; }

}
