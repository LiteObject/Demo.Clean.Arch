using Autofac;
using Demo.Clean.Arch.Core.Interfaces;
using Demo.Clean.Arch.Core.Services;

namespace Demo.Clean.Arch.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
