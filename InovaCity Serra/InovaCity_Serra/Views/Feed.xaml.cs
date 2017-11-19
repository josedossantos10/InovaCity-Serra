using InovaCity_Serra.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InovaCity_Serra.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Feed : ContentPage
	{
        public Feed ()
		{
			InitializeComponent ();
            BindingContext = new FeedViewModel();
        }
    }
}