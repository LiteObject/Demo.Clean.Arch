using Demo.Clean.Arch.Core.ProjectAggregate;
using Demo.Clean.Arch.SharedKernel;

namespace Demo.Clean.Arch.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
