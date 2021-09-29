﻿using Marvel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace Marvel
{
    public partial class MainPage : ContentPage
    {
        private Timer timer;
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

        List<CarrouselClass> CarrouselImg = new List<CarrouselClass>
        {
            new CarrouselClass { Nome = "Yato- O deus da calamidade", ImagemUrl = "https://images8.alphacoders.com/103/1039851.jpg"},
            new CarrouselClass { Nome = "Ozamu Dazai", ImagemUrl = "https://images8.alphacoders.com/113/thumb-1920-1131164.png"},
            new CarrouselClass { Nome = "Kaneki Ken - The one eyed king", ImagemUrl = "https://i0.wp.com/pixelz.cc/wp-content/uploads/2019/02/tokyo-ghoul-ken-kaneki-personalities-uhd-4k-wallpaper.jpg"},
            new CarrouselClass { Nome = "Mirio - Lemillion", ImagemUrl = "https://wallpapercave.com/wp/wp4150780.jpg"},
            new CarrouselClass { Nome = "Shiro e Sora - Kuuhaku", ImagemUrl = "https://wallpapercave.com/wp/wp1825469.jpg"}
        };

        protected override void OnAppearing ( )
        {
            timer = new Timer ( TimeSpan.FromSeconds ( 5 ).TotalMilliseconds ) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing ( );
        }
        protected override void OnDisappearing ( )
        {
            timer?.Dispose ( );
            base.OnDisappearing ( );
        }
        private void Timer_Elapsed ( object sender, ElapsedEventArgs e )
        {
            Device.BeginInvokeOnMainThread ( ( ) =>
             {
                 if ((CarrouselImg.Count-1)==Carrousel.Position)
                 {
                     Carrousel.Position = 1;
                     return;
                 }
                 Carrousel.Position++;
             }
            );
        }

        public MainPage()
        {
            InitializeComponent ();
            CarregaTela ( );
            Carrousel.ItemsSource = CarrouselImg;
        }

        async void CarregaTela ( )
        {
            TelaTotal.Opacity = 0;
            await TelaTotal.FadeTo ( 1, 2000 );
        }


        async void ModoPesquisa ( bool apararece )
        {
            await modoPesquisa.FadeTo ( Convert.ToInt32 ( apararece), 1000 );
        }

        async void ModoNormal (bool apararece )
        {
            await modoPadrao.FadeTo (Convert.ToInt32( apararece), 1000 );
        }


        private void txtBusca_TextChanged ( object sender, TextChangedEventArgs e )
        {
            if (txtBusca.Text.Length >= 3)
            {
                
                var sugestao = Estados.Where ( c => c.ToLower ( ).Contains ( txtBusca.Text.ToLower ( ) ) );
                listaHerois.ItemsSource = sugestao;
                ModoNormal( false);
                modoPadrao.IsVisible = true;
                ModoPesquisa( true);
            }
            else
            {
                ModoPesquisa ( false );
                modoPadrao.IsVisible = true;
                ModoNormal ( true );
            }
        }
    }
}
