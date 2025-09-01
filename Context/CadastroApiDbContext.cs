using CadastroAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroAPI.Context;

public class CadastroApiDbContext : DbContext
{
    public CadastroApiDbContext(DbContextOptions<CadastroApiDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Cliente> Clientes { get; set; }
}