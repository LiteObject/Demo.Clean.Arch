using MediatR;

namespace Demo.Clean.Arch.SharedKernel;

public abstract class BaseDomainEvent : INotification
{
  public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}
