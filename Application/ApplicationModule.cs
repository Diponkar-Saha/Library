using Autofac;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ApplicationModule : Module
    {
        public ApplicationModule()
        {
        }

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
        }
    }
}