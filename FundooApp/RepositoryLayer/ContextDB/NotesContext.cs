using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.ContextDB
{
    public class NotesContext : DbContext
    {
        public NotesContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
