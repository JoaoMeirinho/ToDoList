using ToDoList.Models;

namespace ToDoList.Repositories.Interfaces
{
    public interface ITarefasRepository
    {
        public List<TarefasModel> GetTasks();
        public TarefasModel GetTasks(int id);
        public bool CreateTask(TarefasModel tarefa);
        public bool UpdateTask(int id, TarefasModel tarefa);
        public bool DeleteTask(int id);
    }
}
