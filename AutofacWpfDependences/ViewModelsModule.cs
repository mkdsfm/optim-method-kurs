using System;
using System.Collections.ObjectModel;
using AdministratorFormsWPF.ViewModel;
using Autofac;
using Services.Interfaces;
using User.Model;
using User.ViewModel;

namespace AutofacWpfDependences
{
    public class ViewModelsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new AdministrationViewModel(
                c.Resolve<IUserService>(),
                c.Resolve<IMethodService>(),
                c.Resolve<IParameterService>(),
                c.Resolve<ITasksService>(),
                c.Resolve<IUnitOfMeasService>()))
                .AsSelf();

            builder.Register(c => new UserViewModel(
                    c.Resolve<ITasksService>(),
                    c.Resolve<IMethodService>()))
                .AsSelf();
        }
    }
}
