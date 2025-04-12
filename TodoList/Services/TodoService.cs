
namespace TodoList.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<TodoItem> _todoItems;

        public TodoService()
        {
            _todoItems = new List<TodoItem>
            {
                new TodoItem("Wash Clothes"),
                new TodoItem("Clean Desk")
            };
        }

        void ITodoService.Add(TodoItem item)
        {
            _todoItems.Add(item);
        }

        void ITodoService.Delete(TodoItem item)
        {
            _todoItems.Remove(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todoItems.ToList();
        }

        public void Complete(TodoItem item)
        {
            item.Completed = true;
        }

        public void Uncomplete(TodoItem item)
        {
            item.Completed = false;
        }
    }
}   
