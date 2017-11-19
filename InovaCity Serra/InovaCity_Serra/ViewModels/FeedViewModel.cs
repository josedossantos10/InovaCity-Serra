using InovaCity_Serra.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace InovaCity_Serra.ViewModels
{

    public class FeedViewModel
    {
        private ObservableCollection<Int32> publicacoes;
        private ICommand logarCommand;
        public ICommand LogarCommand { get => logarCommand; set => logarCommand = value; }
        private ICommand criarPublicacaoCommand;
        public ICommand CriarPublicacaoCommand { get => criarPublicacaoCommand; set => criarPublicacaoCommand = value; }



        public FeedViewModel()
        {
            this.logarCommand = new Command(this.Logar);
            this.criarPublicacaoCommand = new Command(this.CriarPublicacao);
            publicacoes = new ObservableCollection<int>
            {
                1,
                2,
                3,
                4,
                4,
                4,
                4,
                4,
               
            };

        }

        private void CriarPublicacao(object obj)
        {
            InovaCity_Serra.App.Current.MainPage.Navigation.PushAsync(new Publicacao());
        }

        private void Logar(object obj)
        {
        InovaCity_Serra.App.Current.MainPage.Navigation.PushModalAsync(new Login());
        }

        public ObservableCollection<int> Publicacoes { get => publicacoes; set => publicacoes = value; }
    }




}
