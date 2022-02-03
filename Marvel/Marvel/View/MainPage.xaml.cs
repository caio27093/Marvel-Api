using Marvel.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using Flurl;
using Flurl.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace Marvel
{
    public partial class MainPage : ContentPage
    {
        public static Quadrinhos.Root quadrinhos;
        public static Personagens.Root personagens;
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
        static List<CarrouselClass> CarrouselImg;

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
                 if ((CarrouselImg.Count - 1) == Carrousel.Position)
                 {
                     Carrousel.Position = 1;
                     return;
                 }
                 Carrousel.Position++;
             }
            );
        }

        public MainPage ( )
        {
            InitializeComponent ( );
            CarregaTela ( );
            CarregaClasses ( );
        }

        async void CarregaTela ( )
        {
            TelaTotal.Opacity = 0;
            await TelaTotal.FadeTo ( 1, 2000 );
        }

        async void CarregaClasses()
        {

            #region GET INICIAIS
            try
            {
                #region QUADRINHOS
                string result;
                string url = ConstantesChaves.url_fixa + "comics?ts=" + ConstantesChaves.timestamp + "&apikey=" + ConstantesChaves.chave_publica + "&hash=" + ConstantesChaves.hash;
                HttpWebRequest request;
                request = (HttpWebRequest)WebRequest.Create ( url );
                request.Headers.Clear();
                request.ContentType = "application/json";
                request.Method = "GET";
                WebResponse retorno = request.GetResponse();

                using (Stream stream = request.GetResponse().GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);

                    result = reader.ReadToEnd();
                }
                quadrinhos = JsonConvert.DeserializeObject<Quadrinhos.Root> ( result );
                #endregion

                #region PERSONAGENS
                string result1;
                string url1 = ConstantesChaves.url_fixa + "characters?ts=" + ConstantesChaves.timestamp + "&apikey=" + ConstantesChaves.chave_publica + "&hash=" + ConstantesChaves.hash;
                HttpWebRequest request1;
                request1 = (HttpWebRequest)WebRequest.Create(url1);
                request1.Headers.Clear();
                request1.ContentType = "application/json";
                request1.Method = "GET";
                WebResponse retorno1 = request1.GetResponse();

                using (Stream stream1 = request1.GetResponse().GetResponseStream())
                {
                    StreamReader reader1 = new StreamReader(stream1, Encoding.UTF8);

                    result1 = reader1.ReadToEnd();
                }
                personagens = JsonConvert.DeserializeObject<Personagens.Root>(result1);
                #endregion

                List<CarrouselClass> CarrouselImg1 = new List<CarrouselClass>
                {
                    new CarrouselClass { Nome = personagens.Data.Results[0].Name, ImagemUrl = personagens.Data.Results[0].Thumbnail.Path+"."+personagens.Data.Results[0].Thumbnail.Extension},
                    new CarrouselClass { Nome = personagens.Data.Results[1].Name, ImagemUrl = personagens.Data.Results[1].Thumbnail.Path+"."+personagens.Data.Results[1].Thumbnail.Extension},
                    new CarrouselClass { Nome = personagens.Data.Results[2].Name, ImagemUrl = personagens.Data.Results[2].Thumbnail.Path+"."+personagens.Data.Results[2].Thumbnail.Extension},
                    new CarrouselClass { Nome = personagens.Data.Results[3].Name, ImagemUrl = personagens.Data.Results[3].Thumbnail.Path+"."+personagens.Data.Results[3].Thumbnail.Extension},
                    new CarrouselClass { Nome = personagens.Data.Results[4].Name, ImagemUrl = personagens.Data.Results[4].Thumbnail.Path+"."+personagens.Data.Results[4].Thumbnail.Extension}
                };
                CarrouselImg = CarrouselImg1;
                Carrousel.ItemsSource = CarrouselImg1;

            }
            catch (Exception ex)
            {

            }
            #endregion
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
