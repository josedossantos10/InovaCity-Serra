using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SQLite.Net.Interop;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(InovaCity_Serra.iOS.Config))]
namespace InovaCity_Serra.iOS
{
    class Config : IConfig
    {
        private ISQLitePlatform _plataforma;
        private string _diretorioBD;

        public Config()
        {
        }

        public string DiretorioBD
        {
            get
            {
                if (string.IsNullOrEmpty(_diretorioBD))
                {
                    var diretorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    _diretorioBD = System.IO.Path.Combine(diretorio, "..", "Library");
                }
                return _diretorioBD;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get
            {
                if (_plataforma == null)
                {
                    _plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();

                }
                return _plataforma;
            }
        }
    }
}