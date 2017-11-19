using InovaCity_Serra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InovaCity_Serra.Views
{
	public partial class Cadastro : ContentPage
	{

        public Cadastro ()
		{
			InitializeComponent ();
            BindingContext = new CadastroViewModel();
            }
    }
}