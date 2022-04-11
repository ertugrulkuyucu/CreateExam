using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SınavOlusturma.Models;

namespace SınavOlusturma.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SınavOlusturma.Models.Question> Question { get; set; }
        public DbSet<SınavOlusturma.Models.Exam> Exam { get; set; }
    }
}
