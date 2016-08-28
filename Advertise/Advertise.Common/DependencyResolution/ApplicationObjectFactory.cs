﻿using System;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Advertise.Common.Controller;
using Advertise.Common.DependencyResolution.Registeries;
using Advertise.DataLayer.Context;
using AutoMapper;
using StructureMap;
using StructureMap.Web;

namespace Advertise.Common.DependencyResolution
{
    /// <summary>
    /// </summary>
    public static class ApplicationObjectFactory
    {
        #region Fields

        private static readonly Lazy<Container> ContainerBuilder = new Lazy<Container>(DefaultContainer,
            LazyThreadSafetyMode.ExecutionAndPublication);

        #endregion

        #region Container

        public static IContainer Container => ContainerBuilder.Value;

        #endregion

        #region DefaultContainer

        /// <summary>
        /// </summary>
        /// <returns></returns>
        private static Container DefaultContainer()
        {
            var container = new Container(ioc =>
            {
                ioc.For<IIdentity>()
                    .Use(
                        () =>
                            HttpContext.Current != null && HttpContext.Current.User != null
                                ? HttpContext.Current.User.Identity
                                : null);

                ioc.For<IUnitOfWork>().HybridHttpOrThreadLocalScoped().Use<ApplicationDbContext>();

                ioc.For<HttpContextBase>().Use(() => new HttpContextWrapper(HttpContext.Current));

                ioc.For<HttpServerUtilityBase>().Use(() => new HttpServerUtilityWrapper(HttpContext.Current.Server));

                ioc.For<HttpRequestBase>().Use(ctx => ctx.GetInstance<HttpContextBase>().Request);

                ioc.For<ISessionProvider>().Use<SessionProvider>();

                ioc.For<IRemotingFormatter>().Use(ctx => new BinaryFormatter());

                ioc.For<ITempDataProvider>().Use<CookieTempDataProvider>();

                ioc.AddRegistry<AspNetIdentityRegistery>();
                ioc.AddRegistry<AutoMapperRegistery>();
                ioc.AddRegistry<ServiceLayerRegistery>();
                ioc.AddRegistry<TaskRegistry>();

                ioc.Scan(scanner => scanner.WithDefaultConventions());
                ioc.Policies.SetAllProperties(y => y.OfType<HttpContextBase>());
            });

            ConfigureAutoMapper(container);

            return container;
        }

        #endregion

        /// <summary>
        /// </summary>
        /// <param name="container"></param>
        private static void ConfigureAutoMapper(IContainer container)
        {
            container.GetInstance<IMapper>().ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}