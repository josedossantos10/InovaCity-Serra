using System;
using System.Collections.Generic;
using System.Text;
using InovaCity_Serra.Model;
using Xamarin.Forms;
using InovaCity_Serra.DAO;

namespace InovaCity_Serra.ViewModels
{

    public class CadastroViewModel : BaseViewModel
    {
        private static string[] estados = { "Acre", "Alagoas", "Amapá", "Amazonas", "Bahia", "Ceará", "Distrito Federal", "Espírito Santo", "Goiás", "Maranhão", "Mato Grosso", "Mato Grosso do Sul", "Minas Gerais", "Pará", "Paraíba", "Paraná", "Pernambuco", "Piauí", "Rio de Janeiro", "Rio Grande do Norte", "Rio Grande do Sul", "Rondônia", "Roraima", "Santa Catarina", "São Paulo", "Sergipe", "Tocantins" };
        private static string[] sexos = { "Masculino", "Feminino", "Não informar" };
        private Usuario usuario;
        public Command SalvarCommand { get; private set; }
        public string[] Estados { get => estados; set => estados = value; }
        public string[] Sexos{get => sexos; set => sexos = value;}
        AcessoDados dao = new AcessoDados();
        private List<Usuario> lista;

        public List<Usuario> Lista
        {
            get => lista;
            set
            {
                lista = value;
                OnPropertyChanged();
            }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                OnPropertyChanged();
                SalvarCommand.ChangeCanExecute();
            }

        }


        public CadastroViewModel()
        {
            //dao.Inserir(new Usuario
            //{
            //    Nome = "Jose",
            //    Senha = "111111",
            //    Celular = "12345",
            //    Cpf = "110478540",
            //    Email = "josedosantos@outlook.com"
            //});
            lista = dao.ObterTodos();
            usuario = new Usuario();
            SalvarCommand = new Command(ExecuteSalvarCommand, CanExecuteSalvarCommand);

        }

        private bool CanExecuteSalvarCommand() => true;
        // private bool CanExecuteSalvarCommand() => usuario.Senha.Length >= 4 && usuario.Email.Contains("@") && usuario.Email.Contains(".com") && usuario.Celular.Length==11 && usuario.Cpf.Length==11;

        private void ExecuteSalvarCommand()
        {
            // Salvar os dados do usuario
            dao.Inserir(usuario);
            lista = dao.ObterTodos();

        }






    }

}

