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
        public static int offset_Personagens;
        public static int offset_Quadrinhos;

        public DetalhesDaPagina (int tipoTela)
        {
            InitializeComponent ( );
            if (tipoTela == 1)
                txttitulo.Text = "Quadinhos";
            else
                txttitulo.Text = "Personagens";
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}