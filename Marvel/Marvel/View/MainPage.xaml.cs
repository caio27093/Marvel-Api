using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Marvel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent ();
        }

        List<string> Estados = new List<string>
        {
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"
        };

        private void txtBusca_TextChanged ( object sender, TextChangedEventArgs e )
        {
            if (txtBusca.Text.Length >= 3)
            {
                
                var sugestao = Estados.Where ( c => c.ToLower ( ).Contains ( txtBusca.Text.ToLower ( ) ) );
                listaHerois.ItemsSource = sugestao;
                modoPadrao.IsVisible = false;
                modoPesquisa.IsVisible = true;
            }
            else
            {
                modoPadrao.IsVisible = true;
                modoPesquisa.IsVisible = false;
            }
        }
    }
}
