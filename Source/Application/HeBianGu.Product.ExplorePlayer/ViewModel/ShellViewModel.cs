﻿using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;
using HeBianGu.General.WpfMvc; 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace HeBianGu.Product.ExplorePlayer
{
    [ViewModel("Shell")]
    class ShellViewModel : WindowLinkViewModel
    {


        private TabLink _currentLink;
        /// <summary> 说明  </summary>
        public TabLink CurrentLink
        {
            get { return _currentLink; }
            set
            {
                _currentLink = value;
                RaisePropertyChanged("CurrentLink");
            }
        }

        Random random = new Random();

        protected async override void RelayMethod(object obj)
        {
            string command = obj.ToString();

            //  Do：应用
            if (command == "Sumit")
            {
                this.IsBuzy = true;

                await Task.Run(() =>
                {
                    Thread.Sleep(500);

                    string err;

                    var result = AssemblyDomain.Instance.Login(this.LoginUseName, this.LoginPassWord, this.Remenber, out err);

                    if (result)
                    {
                        this.LoginMessage = "登录成功";
                        this.IsBuzy = false;

                        Task.Delay(500).ContinueWith(l =>
                        {
                            this.IsLogined = true;

                        });
                    }
                    else
                    {
                        this.IsBuzy = false;
                        this.IsEnbled = false;

                        //this.LoginMessage = "网络错误，登录失败";
                        this.LoginMessage = err;

                        Task.Delay(1000).ContinueWith(l =>
                        {
                            this.LoginMessage = "登录";
                            this.IsEnbled = true;
                        });
                    }
                    //});

                });

            }
            //  Do：取消
            else if (command == "Cancel")
            {

            }

            //  Do：取消
            else if (command == "init")
            {
                //  Do：加载记住账号和密码
                var result = AssemblyDomain.Instance.GetAccountConfig();

                if (result != null)
                {
                    if (result.Remenber)
                    {
                        this.LoginPassWord = result.LoginPassWord;
                        this.Remenber = true;
                    }
                    this.LoginUseName = result.LoginUseName;

                }
            }
        }
    }

   

}
