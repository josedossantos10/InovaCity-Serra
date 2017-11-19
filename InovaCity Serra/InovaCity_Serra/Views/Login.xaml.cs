using InovaCity_Serra.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InovaCity_Serra.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login
	{
		public Login ()
		{
			InitializeComponent ();
            BindingContext = new LoginViewModel();

        }
        private void AbrirCadastro()
        {
           Navigation.PushModalAsync(new Cadastro());
            //new NavigationPage(new Cadastro());
        }
    }
}