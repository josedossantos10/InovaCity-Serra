using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Shapes;
using Xamarin.Forms;


[assembly: Dependency(typeof(InovaCity_Serra.UWP.Config))]
namespace InovaCity_Serra.UWP
{
    class Config: IConfig
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
                    _diretorioBD = ApplicationData.Current.LocalFolder.Path;
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
                    _plataforma = new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT();

                }
                return _plataforma;
            }
        }
    }
}
