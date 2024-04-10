using ToDoList.Context;
using ToDoList.Models;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.Repositories
{
    public class TarefasRepository : ITarefasRepository
    {
        private readonly AppDbContext _context;

        public TarefasRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateTask(TarefasModel tarefa)
        {
            _context.Add(tarefa);
            await _context.SaveChangesAsync();
        }

        public Task DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TarefasModel> GetTasks()
        {
            return _context.Tarefas;
        }

        public Task<TarefasModel> GetTasks(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TarefasModel> UpdateTask(int id, TarefasModel tarefa)
        {
            throw new NotImplementedException();
        }

    }
}
