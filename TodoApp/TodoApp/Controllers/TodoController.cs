using Microsoft.AspNetCore.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        static public List<TodoItem> todoList = new List<TodoItem>();
        public IActionResult Index()
        {
            return View(todoList);
        }

        public IActionResult Create()
        {
            var newTodo = new TodoItem();
            return View(newTodo);
        }

        public IActionResult CreateTodo(TodoItem todo)
        {
            todoList.Add(todo);
            return RedirectToAction(nameof(Index));
        }
    }
}
