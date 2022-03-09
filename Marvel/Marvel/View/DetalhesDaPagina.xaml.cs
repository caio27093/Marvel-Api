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

        public DetalhesDaPagina (int tipoTela)
        {
            InitializeComponent ( );
            if (tipoTela == 1)
                txttitulo.Text = "Quadinhos";
            else
                txttitulo.Text = "Personagens";
            this.BindingContext = new DetalhesViewModel(tipoTela);
        }


    }
}