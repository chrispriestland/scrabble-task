using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DataLayer;
using DataLayer.Contracts;
using DataLayer.Models;
using DataLayer.Repositories;
using DomainLayer;
using DomainLayer.Services;
using Unity;
using Unity.Mvc5;

namespace Scrabble
{
	public class MvcApplication : HttpApplication
	{
		private static IUnityContainer _unityContainer;

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			SetupDependencyInjection();
		}

		private static void SetupDependencyInjection()
		{
			_unityContainer = new UnityContainer();
			DependencyResolver.SetResolver(new UnityDependencyResolver(_unityContainer));
			_unityContainer.RegisterType<IBaseRepository, BaseRepository>();
			_unityContainer.RegisterType<IMemberRepository, MemberRepository>();
			_unityContainer.RegisterType<IUnitOfWork, DatabaseContext>();
			_unityContainer.RegisterType<IMemberServices, MemberServices>();
		}
	}
}
