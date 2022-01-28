#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebMongoDB.Models;

namespace WebMongoDB.Data
{
    public class WebMongoDBContext : DbContext
    {
        public WebMongoDBContext (DbContextOptions<WebMongoDBContext> options)
            : base(options)
        {
        }

        public DbSet<WebMongoDB.Models.Usuario> Usuario { get; set; }
    }
}
