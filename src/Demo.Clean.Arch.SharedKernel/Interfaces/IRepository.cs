using Ardalis.Specification;

namespace Demo.Clean.Arch.SharedKernel.Interfaces;

// from Ardalis.Specification
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
