using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Notes.Models
{
    public class NotesContext : IdentityDbContext<IdentityUser>
    {
        public NotesContext(DbContextOptions<NotesContext> options) : base(options)
        {
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}