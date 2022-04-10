
using System;
using System.Linq;
using System.Web.Mvc;
using TodoApp.Models.Todo;
using TodoApp.Persistence;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private TodoAppEntities _context = new TodoAppEntities(); 
        //static public List<TodoItem> todoList = new List<TodoItem>();
        
        [HttpGet]
        public ActionResult Index()
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

        //simple API that returns Json
        public JsonResult Get()
        {
            var todoList = _context.TodoItem
                .Select(x => new TodoItemModel
                {
                    TodoId = x.TodoId,
                    TodoName = x.TodoName,
                    Done = x.Done
                })
                .ToList();
            return Json(todoList,JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Create()
        {
            var newTodo = new TodoItemModel();
            return View(newTodo);
        }

        [HttpGet]
        public ActionResult Delete(int todoId)
        {
            var todoItem = _context.TodoItem
                .Where(x => x.TodoId == todoId)
                .SingleOrDefault();

            if(todoItem == null)
            {
                throw new ApplicationException("TodoItem Id not Found!");
            }
                
            _context.TodoItem.Remove(todoItem);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Edit(int todoId)
        {
            var editingItem = _context.TodoItem
                .Where(x => x.TodoId == todoId)
                .Select(x => new TodoItemModel {TodoId = x.TodoId, TodoName = x.TodoName, Done = x.Done})
                .SingleOrDefault();

            if (editingItem == null)
                throw new ApplicationException("Item doesnt exist");

            return View("Create", editingItem);
        }

        [HttpPost]
        public ActionResult Edit(TodoItemModel item)
        {
            var editingItem = _context.TodoItem
                .Where(x => x.TodoId == item.TodoId)
                .SingleOrDefault();

            if (editingItem == null)
                throw new ApplicationException("something went wrong mate");
              
            editingItem.TodoName = item.TodoName;
            editingItem.Done = item.Done;

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public ActionResult CreateTodo(TodoItemModel todo)
        {
            _context.TodoItem.Add(new TodoItem { Done = todo.Done, TodoName = todo.TodoName });
            _context.SaveChanges();
            //todoList.Add(todo);
            return RedirectToAction(nameof(Index));
        }

        //API post
        public JsonResult Post(TodoItemModel todo)
        {
            _context.TodoItem.Add(new TodoItem { Done = todo.Done, TodoName = todo.TodoName });
            _context.SaveChanges();

            return Json(todo);
        }
    }
}
