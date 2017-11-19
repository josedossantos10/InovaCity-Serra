using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace InovaCity_Serra
{
    public interface IConfig
    {
        string DiretorioBD { get; }

        ISQLitePlatform Plataforma { get; }
    }

}
