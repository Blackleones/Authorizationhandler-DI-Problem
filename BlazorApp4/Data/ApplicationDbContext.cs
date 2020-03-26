using System;
using System.Collections.Generic;
using System.Text;
using BlazorApp4.Areas.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp4.Data
{
    public class Todo 
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext
    {
        private readonly ICurrentUser _currentUser;

        public DbSet<Todo> Todos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
