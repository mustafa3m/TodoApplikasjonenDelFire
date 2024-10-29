using System.Collections.Generic;
using System.Linq;



public class TodoService
{
    private readonly List<TodoItem> _todos = new List<TodoItem>();

    // Expose Todos as a read-only collection
    public IReadOnlyList<TodoItem> Todos => _todos;

    // Add a new todo
    public void AddTodo(string title)
    {
        var todo = new TodoItem { Title = title, IsCompleted = false };
        _todos.Add(todo);
    }

    // Mark a todo item as completed
    public void MarkAsComplete(TodoItem todo)
    {
        var existingTodo = _todos.FirstOrDefault(t => t == todo);
        if (existingTodo != null)
        {
            existingTodo.IsCompleted = true;
        }
    }

    // Remove a todo item
    public void RemoveTodoItem(TodoItem todo)
    {
        _todos.Remove(todo);
        Console.WriteLine($"Todo list after deletion: {string.Join(", ", _todos.Select(t => t.Title))}");
    }

    // Get the list of completed todos
    public List<TodoItem> GetCompletedTodos()
    {
        return _todos.Where(todo => todo.IsCompleted).ToList();
    }

    public void UndoComplete(TodoItem todo)
    {
        todo.IsCompleted = false;
    }
}