using Ardalis.Specification;

namespace Demo.Clean.Arch.Core.ProjectAggregate.Specifications;

public class IncompleteItemsSearchSpec : Specification<ToDoItem>
{
  public IncompleteItemsSearchSpec(string searchString)
  {
    Query
        .Where(item => !item.IsDone &&
        (item.Title.Contains(searchString) ||
        item.Description.Contains(searchString)));
  }
}
