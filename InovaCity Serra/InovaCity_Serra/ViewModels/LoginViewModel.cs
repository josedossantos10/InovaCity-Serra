using InovaCity_Serra.Views;
using Xamarin.Forms;

namespace InovaCity_Serra.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string email;
        private string senha;

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged();
                EntrarCommand.ChangeCanExecute();
            }
        }


        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
                OnPropertyChanged();
                EntrarCommand.ChangeCanExecute();

            }
        }

        private string saudacao;


        public string Saudacao {
            get
        {
            return saudacao;
        }set{
            saudacao = value;
            OnPropertyChanged();
        }}


        //Comands
        public Command EntrarCommand { get; private set; }
        public Command EntrarFacebookCommand { get; private set; }


        public LoginViewModel()
        {
            EntrarFacebookCommand = new Command(ExecuteEntrarFacebookCommand);
            EntrarCommand = new Command(ExecuteEntrarCommand, CanExecuteEntrarCommand);
            email = "";
            senha = "";
            saudacao = "";

        }

        private bool CanExecuteEntrarCommand()
        {
            return senha.Length>=4 && email.Contains("@") && email.Contains(".com");   }

        private void ExecuteEntrarCommand()
        {
           Saudacao=("Aguarde!, Função não Implementada");

            // Realizar login
        }

        private void ExecuteEntrarFacebookCommand()
        {
            Saudacao = ("Aguarde!, Função não Implementada");

            // Realizar login com facebook
        }

   

    }

   
}
