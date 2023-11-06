using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechchallengeNoticias.Models;
using Webapiaspnet.Models;

namespace Webapiaspnet.Data
{
    public class WebApiContext : IdentityDbContext<Usuario>
    {
        public WebApiContext(DbContextOptions<WebApiContext> opts)
            : base(opts)
        {
                
        }
        public DbSet<Noticia> Noticia { get; set; }
    }
}