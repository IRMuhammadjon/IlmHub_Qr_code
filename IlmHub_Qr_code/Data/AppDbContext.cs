using IlmHub_Qr_code.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace IlmHub_Qr_code.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Student?> student { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }

}
