using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InovaCity_Serra.Servicos
{
     public class ImageButton: Image
    {

        public static BindableProperty CommandProperty =
            BindableProperty.Create(nameof(ImageButton), typeof(ICommand), typeof(ICommand), default(ICommand));

        public ICommand Command { get; set; }

        public ImageButton()
        {
            var gesto = new TapGestureRecognizer();
            gesto.Tapped += (sender, e) => {

                if (this.Command!=null && this.Command.CanExecute(null))
                {
                    this.Command.Execute(null);
                }
            };
            this.GestureRecognizers.Add(gesto);
        }
    }
}
