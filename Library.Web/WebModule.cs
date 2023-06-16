using Autofac;
using Library.Web.Areas.Admin.Models;

namespace Library.Web
{
    public class WebModule : Module
    {
        public WebModule()
        { }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookListModel>().AsSelf()
                .InstancePerLifetimeScope();

            builder.RegisterType<BookCreateModel>().AsSelf()
                .InstancePerLifetimeScope();

            builder.RegisterType<BookUpdateModel>().AsSelf()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }

}
