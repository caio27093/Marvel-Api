using Marvel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Marvel.View
{
    [XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class DetalhesDaPagina : ContentPage
    {
        public static int offset_Personagens = 1;
        public static int offset_Quadrinhos = 1;
        public static int tipotela_geral;
        public DetalhesDaPagina (int tipoTela)
        {
            InitializeComponent ( );
            if (tipoTela == 1)
                txttitulo.Text = "Quadinhos";
            else
                txttitulo.Text = "Personagens";
            tipotela_geral = tipoTela;
            this.BindingContext = new DetalhesViewModel(tipoTela);
            //this.BindingContext = new StackLayoutViewModel();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            offset_Quadrinhos = 1;
            offset_Personagens = 1;
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (tipotela_geral==1)
                {
                    offset_Quadrinhos = offset_Quadrinhos + 15;
                }
                else
                {
                    offset_Personagens = offset_Personagens + 15;
                }
                this.BindingContext = new DetalhesViewModel(tipotela_geral);
            });
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {

            Device.BeginInvokeOnMainThread(() =>
            {
                if (tipotela_geral == 1)
                {
                    offset_Quadrinhos = offset_Quadrinhos - 15;
                    if (offset_Quadrinhos<1)
                    {
                        offset_Quadrinhos = 1;
                        DependencyService.Get<Interfaces.IMessage>().LongAlert("Limite inicial alcançado");
                    }
                }
                else
                {
                    offset_Personagens = offset_Personagens - 15; 
                    if (offset_Personagens < 1)
                    {
                        offset_Personagens = 1;
                        DependencyService.Get<Interfaces.IMessage>().LongAlert("Antes disso só o The One Below All");
                    }
                }
                this.BindingContext = new DetalhesViewModel(tipotela_geral);
            });
        }
    }
}