using Application.Features.Training.Services;
using Autofac;
using Infrastructure.Features.Services;
using System;

using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure
{
    public class InfrastructureModule : Module
    {
        public InfrastructureModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookService>().As<IBookService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}