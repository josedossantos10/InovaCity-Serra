using InovaCity_Serra.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace InovaCity_Serra.DAO
{
    public class AcessoDados : IDisposable
    {
        private SQLite.Net.SQLiteConnection _connection;

        public AcessoDados()
        {
            var config = DependencyService.Get<IConfig>();
            _connection = new SQLite.Net.SQLiteConnection(config.Plataforma, System.IO.Path.Combine(config.DiretorioBD, "bancodedados.db3"));
            _connection.CreateTable<Usuario>();
        }


        public void Inserir(Usuario usuario)
        {
            _connection.Insert(usuario);
        }

        public void Atualizar(Usuario usuario)
        {
            _connection.Update(usuario);
        }

        public void Remover(Usuario usuario)
        {
            _connection.Delete(usuario);
        }


        public Usuario ObterPorId(int id)
        {
            return _connection.Table<Usuario>().FirstOrDefault(c => c.Id == id);
        }

        public List<Usuario> ObterTodos()
        {
            return _connection.Table<Usuario>().OrderBy(c => c.Nome).ToList();
        }

        public void Dispose()
        {
            _connection.Dispose();

        }
    }
}
