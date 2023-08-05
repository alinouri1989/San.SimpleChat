using Autofac;
using San.SimpleChat.Core.Repository_Interfaces;
using San.SimpleChat.DataRepositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace San.SimpleChat.DependencyResolver
{
    public static class RepositoryAutofacModule
    {
        public static ContainerBuilder CreateAutofacRepositoryContainer(this IServiceCollection services, ContainerBuilder builder)
        {
            //var databaseInitializer = new MigrateToLatestVersion(new SampleDataSeeder());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            return builder;
        }
    }

    public class RepositoryAutofacModule1:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //var databaseInitializer = new MigrateToLatestVersion(new SampleDataSeeder());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
        }
    }
}
