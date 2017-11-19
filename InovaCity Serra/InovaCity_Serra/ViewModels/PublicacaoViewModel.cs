using InovaCity_Serra.Views;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.ExternalMaps;
using Plugin.Geolocator;

namespace InovaCity_Serra.ViewModels
{
    public class PublicacaoViewModel : BaseViewModel
    {
     

        private ICommand logarCommand;
        public ICommand LogarCommand { get => logarCommand; set => logarCommand = value; }
        private ICommand publicarCommand;
        public ICommand PublicarCommand { get => publicarCommand; set => publicarCommand = value; }



        public PublicacaoViewModel()
        {
             this.logarCommand = new Command(this.Logar);
         //   this.publicarCommand = new Command();

        }

        private void Logar()
        {
           
            InovaCity_Serra.App.Current.MainPage.Navigation.PushModalAsync(new Login());
        }




    
       




    }
}
