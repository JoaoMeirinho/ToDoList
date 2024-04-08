using ToDoList.Models;
using Microsoft.EntityFrameworkCore;
using System.Formats.Tar;

namespace ToDoList.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<TarefasModel> Tarefas { get ; set; }
        public DbSet<UserModel> Users { get ; set; }
    }

}
