using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CursoDesenvolvedor_io.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
    public DbSet<CursoDesenvolvedor_io.Components.Produto.Produto> Produto { get; set; } = default!;
    }
}
