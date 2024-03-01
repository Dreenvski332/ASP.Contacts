using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesContact.Models;

namespace RazorPagesContact.Data
{
    public class RazorPagesContactContext : DbContext
    {
        public RazorPagesContactContext (DbContextOptions<RazorPagesContactContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesContact.Models.Contact> Contact { get; set; } = default!;
    }
}
