using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstCore.Models;

namespace MyFirstCore.Data;

public partial class DatabaseStudentContext : IdentityDbContext
{

    public DatabaseStudentContext(DbContextOptions<DatabaseStudentContext> options)
        : base(options)
    {
    }

    public DbSet<Student>? Students { get; set; }



}
