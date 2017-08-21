using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace EnityFramework
{
    class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            
        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
