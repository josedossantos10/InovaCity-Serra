using InovaCity_Serra.ViewModels;
using Plugin.ExternalMaps;
using Plugin.Geolocator;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace InovaCity_Serra.Views
{
   // [ContentProperty("Children")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Publicacao
	{
        private double latitude = 0;
        private double longitude = 0;

        public Publicacao ()
		{
			InitializeComponent ();
            BindingContext = new PublicacaoViewModel();
		}


        public async void ObterLocalizacaoAsync()
        {

            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 50;

            var position = await locator.
                GetPositionAsync(timeoutMilliseconds: 10000);


            //l.Text += "Status: " + position.Timestamp + "\n";
            //l.Text += "Latitude: " + position.Latitude + "\n";
            //l.Text += "Longitude: " + position.Longitude;

            latitude = position.Latitude;
            longitude = position.Longitude;
            //await CrossExternalMaps.Current.NavigateTo("Minha Localização", latitude, longitude);

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DD.Text = "Latitude" + latitude + "/n Longitude" + longitude;
           // Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(latitude, longitude), Distance.FromMeters(100)));

        }
    }
}