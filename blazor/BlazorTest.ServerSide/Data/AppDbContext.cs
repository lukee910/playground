using System.Text.Json;
using BlazorTest.ServerSide.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BlazorTest.ServerSide.Data;

public class AppDbContext : DbContext
{
    public DbSet<Kanji> Kanjis { get; set; } = default!;
    public DbSet<Reading> Readings { get; set; } = default!;

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Kanji>()
            .Property(k => k.Meanings)
            .HasConversion(
                m => JsonSerializer.Serialize(m, JsonSerializerOptions.Default),
                m => JsonSerializer.Deserialize<List<string>>(m, JsonSerializerOptions.Default) ?? new List<string>(),
                new ValueComparer<List<string>>(
                    (a, b) => a != null && b != null && a.SequenceEqual(b),
                    m => m.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                    m => m.ToList()
                )
            );
    }
}