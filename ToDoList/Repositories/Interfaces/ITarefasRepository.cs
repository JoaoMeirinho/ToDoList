using ToDoList.Models;

namespace ToDoList.Repositories.Interfaces
{
    public interface ITarefasRepository
    {
        public IEnumerable<TarefasModel> GetTasks();
        public Task<TarefasModel> GetTasks(int id);
        public Task CreateTask(TarefasModel tarefa);
        public Task<TarefasModel> UpdateTask(int id, TarefasModel tarefa);
        public Task DeleteTask(int id);
    }
}
