﻿using HeBianGu.Common.Logger;
using HeBianGu.ExplorePlayer.Base.Model;
using HeBianGu.ExplorePlayer.General.SqliteDataBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tester
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //mbc_dc_case from = new mbc_dc_case();

            //from.Name = "etete";

            //SqliteDBService.Instance.AddCase(from);


            ILogService logService = new LogService();

            logService.Info("SDGDSGDGFGFGDFGDF");



    }
}


    class My
    {
        [JsonProperty(PropertyName = "Name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        private string _name_for_old_contract
        {
            get { return null; }
            set { NewName = value; }
        }

        [JsonProperty]
        public string NewName { get; set; }
    }
}
