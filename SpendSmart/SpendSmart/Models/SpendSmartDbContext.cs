using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models
{   
    //definição da classe que herda o DbContext, veio do Framework Core para gerenciar a conexão com o banco de dados
    public class SpendSmartDbContext : DbContext
    {   
        //DbSet do tipo Expense permite a consulta a partir do banco de dados
        public DbSet<Expense> Expenses { get; set; }

        //padrão para configuração de banco de dados
        public SpendSmartDbContext(DbContextOptions<SpendSmartDbContext> options) : base(options)
        {

        }
    }
}
