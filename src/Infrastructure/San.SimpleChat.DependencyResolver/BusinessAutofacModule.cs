using Autofac;
using San.SimpleChat.Business;
using San.SimpleChat.Business.ServiceQuery;
using San.SimpleChat.Core.Business_Interface;
using San.SimpleChat.Core.Business_Interface.ServiceQuery;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace San.SimpleChat.DependencyResolver
{
    public static class BusinessAutofacModule
    {
        public static ContainerBuilder CreateAutofacBusinessContainer(this IServiceCollection services, ContainerBuilder builder)
        {
            builder.RegisterType<IMessageService>().As<MessageService>();
            builder.RegisterType<IMessageServiceQuery>().As<MessageServiceQuery>();
            return builder;
        }
    }

    public class BusinessAutofacModule1 : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<MessageServiceQuery>().As<IMessageServiceQuery>();
        }
    }
}
