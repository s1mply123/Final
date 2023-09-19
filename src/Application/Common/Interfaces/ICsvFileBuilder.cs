using Final.Application.TodoLists.Queries.ExportTodos;

namespace Final.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
