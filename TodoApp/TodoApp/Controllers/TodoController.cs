using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;
using TodoApp.Models.Todo;
using TodoApp.Persistence;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private TodoAppEntities _context = new TodoAppEntities();   
        //static public List<TodoItem> todoList = new List<TodoItem>();
        public IActionResult Index()
        {
            var todoList = _context.TodoItem
                .Select(x => new TodoItemModel 
                {
                    TodoId= x.TodoId,
                    TodoName=x.TodoName,
                    Done = x.Done
                })
                .ToList();
            return View(todoList);
        }

        public IActionResult Create()
        {
            var newTodo = new TodoItemModel();
            return View(newTodo);
        }

        public IActionResult CreateTodo(TodoItemModel todo)
        {
            _context.TodoItem.Add(new TodoItem { Done = todo.Done, TodoId = todo.TodoId, TodoName = todo.TodoName });
            _context.SaveChanges();
            //todoList.Add(todo);
            return RedirectToAction(nameof(Index));
        }
    }
}
