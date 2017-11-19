using System;
using Xamarin.Forms;
using SQLite.Net.Interop;


[assembly: Dependency(typeof(InovaCity_Serra.Droid.Config))]

namespace InovaCity_Serra.Droid
{
    class Config : IConfig
    {
        private ISQLitePlatform _plataforma;
        private string _diretorioBD;

        public Config()
        {
        }

        public string DiretorioBD {
            get
            {
                if (string.IsNullOrEmpty(_diretorioBD))
                {
                    _diretorioBD = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

                }
                return _diretorioBD;
            }
        }

        public ISQLitePlatform Plataforma { get
            {
                if (_plataforma == null)
                {
                    _plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
    
            }
                return _plataforma;
            }
        }
    }
}