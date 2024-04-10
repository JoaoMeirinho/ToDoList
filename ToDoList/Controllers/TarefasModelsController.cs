using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using ToDoList.Context;
using ToDoList.Models;
using ToDoList.Repositories;
using ToDoList.Repositories.Interfaces;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasModelsController : ControllerBase
    {
        private readonly ITarefasRepository _tarefas;
        private readonly IUserRepository _user;
        private readonly AppDbContext _context;

        public TarefasModelsController(ITarefasRepository tarefas, IUserRepository user, AppDbContext context)
        {
            _tarefas = tarefas;
            _user = user;
            _context = context;
        }

        // GET: api/TarefasModels
        [HttpGet]
        public ActionResult<IEnumerable<TarefasModel>> GetTarefas()
        {
            return _tarefas.GetTasks().ToList();
        }

        // GET: api/TarefasModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TarefasModel>> GetTarefasModel(int id)
        {
            var tarefasModel = await _tarefas.GetTasks(id);

            if (tarefasModel == null)
            {
                return NotFound();
            }

            return tarefasModel;
        }

        // PUT: api/TarefasModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarefasModel(int id, TarefasModel tarefasModel)
        {
            if (id != tarefasModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(tarefasModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarefasModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TarefasModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TarefasModel>> PostTarefasModel(TarefasModel tarefasModel)
        {
            await _tarefas.CreateTask(tarefasModel);

            return CreatedAtAction("GetTarefasModel", new { id = tarefasModel.Id }, tarefasModel);
        }

        // DELETE: api/TarefasModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarefasModel(int id)
        {
            var tarefasModel = await _tarefas.GetTasks(id);
            if (tarefasModel == null)
            {
                return NotFound();
            }
            await _tarefas.DeleteTask(id);

            return NoContent();
        }

        private bool TarefasModelExists(int id)
        {
            return _tarefas.GetTasks().Any(e => e.Id == id);
        }
    }
}
