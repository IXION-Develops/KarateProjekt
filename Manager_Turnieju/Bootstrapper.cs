﻿using Autofac;
using Caliburn.Micro;
using Caliburn.Micro.Autofac;
using Manager_Turnieju.Data;
using Manager_Turnieju.Models;
using Manager_Turnieju.ViewModels;
using Manager_Turnieju.Views;
using System.Windows;

namespace Manager_Turnieju
{
    public class Bootstrapper : AutofacBootstrapper<AuthorizeViewModel>
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ManagerViewModel>();
        }

        protected override void ConfigureBootstrapper()
        {
            base.ConfigureBootstrapper();
            EnforceNamespaceConvention = false;
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<PlayerMockRepository>().As<IPlayerRepository<Player>>().SingleInstance();
            builder.RegisterType<ClubMockRepository>().As<IClubRepository<Club>>().SingleInstance();

            // Views
            builder.RegisterType<AuthorizeView>();
            builder.RegisterType<AuthorizeViewModel>();
            builder.RegisterType<WindowManager>();
            builder.RegisterType<ManagerViewModel>().SingleInstance();
            builder.RegisterType<PlayersFrameView>();
            builder.RegisterType<PlayersFrameViewModel>();
            builder.RegisterType<AddPlayerViewModel>();
            builder.RegisterType<AddPlayerView>();
        }

    }
}
