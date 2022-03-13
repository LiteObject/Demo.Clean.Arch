using Ardalis.Specification;

namespace Demo.Clean.Arch.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
