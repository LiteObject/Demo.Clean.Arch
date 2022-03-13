using System.Collections.Generic;
using System.Threading.Tasks;
using Ardalis.Result;
using Demo.Clean.Arch.Core.ProjectAggregate;

namespace Demo.Clean.Arch.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
