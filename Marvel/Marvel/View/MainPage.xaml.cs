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
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace Marvel
{
    public partial class MainPage : ContentPage
    {
        public static Quadrinhos.Root quadrinhos;
        public static int primeiro;
        public static int segundo;
        public static int terceiro;
        public static int quarto;
        public static int quinto;
        Personagens.Root personagens;
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

        protected override void OnAppearing()
        {
            timer = new Timer(TimeSpan.FromSeconds(5).TotalMilliseconds) { AutoReset = true, Enabled = true };
            timer.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            timer?.Dispose();
            base.OnDisappearing();
        }
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                if (CarrouselImg != null)
                {
                    if ((CarrouselImg.Count - 1) == Carrousel.Position)
                    {
                        Carrousel.Position = 1;
                        return;
                    }
                    Carrousel.Position++;
                }
            }
            );
        }

        public MainPage()
        {
            InitializeComponent();
            CarregaTela();
            CarregaClasses();
            this.BindingContext = new StackLayoutViewModel();
        }

        async void CarregaTela()
        {
            TelaTotal.Opacity = 0;
            await TelaTotal.FadeTo(1, 2000);
        }

        void CarregaClasses()
        {

            #region GET INICIAIS
            try
            {
                #region QUADRINHOS
                string result;
                string url = ConstantesChaves.url_fixa + "comics?ts=" + ConstantesChaves.timestamp + "&apikey=" + ConstantesChaves.chave_publica + "&hash=" + ConstantesChaves.hash;
                HttpWebRequest request;
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Clear();
                request.ContentType = "application/json";
                request.Method = "GET";
                WebResponse retorno = request.GetResponse();

                using (Stream stream = request.GetResponse().GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);

                    result = reader.ReadToEnd();
                }
                quadrinhos = JsonConvert.DeserializeObject<Quadrinhos.Root>(result);
                #endregion

                #region PERSONAGENS
                string result1;
                string url1 = ConstantesChaves.url_fixa + "characters?" +/*limit=20&*/"ts=" + ConstantesChaves.timestamp + "&apikey=" + ConstantesChaves.chave_publica + "&hash=" + ConstantesChaves.hash;
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

                Random rdn = new Random();

                primeiro = rdn.Next(0, 4);
                segundo = rdn.Next(5, 9);
                terceiro = rdn.Next(10, 14);
                quarto = rdn.Next(15, 19);
                quinto = rdn.Next(15, 19);
                while (quinto == quarto)
                {
                    quinto = rdn.Next(15, 19);
                }

                List<CarrouselClass> CarrouselImg1 = new List<CarrouselClass>
                {
                    new CarrouselClass { Nome = personagens.Data.Results[Convert.ToInt32(primeiro)].Name, ImagemUrl = personagens.Data.Results[Convert.ToInt32(primeiro)].Thumbnail.Path+"."+personagens.Data.Results[Convert.ToInt32(primeiro)].Thumbnail.Extension},
                    new CarrouselClass { Nome = personagens.Data.Results[Convert.ToInt32(segundo)].Name, ImagemUrl = personagens.Data.Results[Convert.ToInt32(segundo)].Thumbnail.Path+"."+personagens.Data.Results[Convert.ToInt32(segundo)].Thumbnail.Extension},
                    new CarrouselClass { Nome = personagens.Data.Results[Convert.ToInt32(terceiro)].Name, ImagemUrl = personagens.Data.Results[Convert.ToInt32(terceiro)].Thumbnail.Path+"."+personagens.Data.Results[Convert.ToInt32(terceiro)].Thumbnail.Extension},
                    new CarrouselClass { Nome = personagens.Data.Results[Convert.ToInt32(quarto)].Name, ImagemUrl = personagens.Data.Results[Convert.ToInt32(quarto)].Thumbnail.Path+"."+personagens.Data.Results[Convert.ToInt32(quarto)].Thumbnail.Extension},
                    new CarrouselClass { Nome = personagens.Data.Results[Convert.ToInt32(quinto)].Name, ImagemUrl = personagens.Data.Results[Convert.ToInt32(quinto)].Thumbnail.Path+"."+personagens.Data.Results[Convert.ToInt32(quinto)].Thumbnail.Extension}
                };
                CarrouselImg = CarrouselImg1;
                Carrousel.ItemsSource = CarrouselImg1;


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            #endregion
        }


        async void ModoPesquisa(bool apararece)
        {
            await modoPesquisa.FadeTo(Convert.ToInt32(apararece), 1000);
        }

        async void ModoNormal(bool apararece)
        {
            await modoPadrao.FadeTo(Convert.ToInt32(apararece), 1000);
        }


        private void txtBusca_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBusca.Text.Length >= 3)
            {

                var sugestao = Estados.Where(c => c.ToLower().Contains(txtBusca.Text.ToLower()));
                listaHerois.ItemsSource = sugestao;
                ModoNormal(false);
                modoPadrao.IsVisible = true;
                ModoPesquisa(true);
            }
            else
            {
                ModoPesquisa(false);
                modoPadrao.IsVisible = true;
                ModoNormal(true);
            }
        }
    }
}
