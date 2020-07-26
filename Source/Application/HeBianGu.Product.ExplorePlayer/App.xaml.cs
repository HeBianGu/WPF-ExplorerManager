﻿using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;
using HeBianGu.General.WpfMvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace HeBianGu.Product.ExplorePlayer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : ApplicationBase
    {
        protected override void OnStartup(StartupEventArgs e)
        { 
            base.OnStartup(e);

            MainWindow shellWindow = new MainWindow();

            LoginWindow loginWindow = new LoginWindow();

            //loginWindow.Title = this.GetWpfControlLibVersonInfo();

            var result = loginWindow.ShowDialog();

            if (result.HasValue && result.Value)
            {
                shellWindow.Show();
            }
            else
            {
                shellWindow.Close();
            }

        }

        protected override void ConfigureServices(IServiceCollection services)
        {
            //  Do：注册Mvc模式
            services.UseMvc();

            //  Do ：注册本地化配置读写服务
            services.AddSingleton<IThemeLocalizeService, LocalizeService>();

            ////  Do ：注册日志服务
            //services.AddSingleton<ILogService, AssemblyDomain>();


        }

        protected override void Configure(IApplicationBuilder app)
        {
            //  Do：设置默认主题
            app.UseLocalTheme(l =>
            {
                l.AccentColor = Color.FromRgb(0x64, 0x76, 0x87);
                l.SmallFontSize = 15D;
                l.LargeFontSize = 18D;
                l.FontSize = FontSize.Small;

                l.ItemHeight = 40;
                //l.ItemWidth = 120;
                l.ItemCornerRadius =5;

                l.RowHeight = 45;

                l.AnimalSpeed = 5000;
                l.AccentColorSelectType = 0;
                l.IsUseAnimal = false;

                l.ThemeType = ThemeType.Light;

                l.Language = Language.Chinese;

                l.DialogCoverBrush = new SolidColorBrush(Colors.Black) { Opacity = 0.6 };

            });

            //app.UseTheme(l => l.DialogCoverBrush = new SolidColorBrush(Colors.Black) { Opacity = 0.6 });
        }
    }
}
