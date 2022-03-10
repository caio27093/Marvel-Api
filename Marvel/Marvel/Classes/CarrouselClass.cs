using Marvel.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net;
using System.Text;
using Xamarin.Forms;

namespace Marvel.Classes
{
    public class CarrouselClass
    {
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
    }
    public class PersonagemClassLista
    {
        public string Nome { get; set; }
        public string ImagemUrl { get; set; }
        public string Descricao { get; set; }
    }
    public class StackLayoutClass
    {
        public string Detalhe { get; set; }
        public string ImagemUrl { get; set; }
    }
    public class DetalhesClass
    {
        public string Detalhe { get; set; }
        public string ImagemUrl { get; set; }
        public string More { get; set; }
    }
    public class StackLayoutViewModel
    {

        public int primeiro;
        public int segundo;
        public int terceiro;
        public int quarto;
        public int quinto;
        public StackLayoutViewModel()
        {
            string imagemIndisponivel = "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available";
            Random rdn = new Random();
            primeiro = rdn.Next(0, 19);
            segundo = rdn.Next(20, 39);
            terceiro = rdn.Next(40, 59);
            quarto = rdn.Next(60, 79);
            quinto = rdn.Next(80, 99);
            bool continua = true;
            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(primeiro)].Thumbnail.Path == imagemIndisponivel)
            {
                do
                {
                    primeiro = rdn.Next(0, 19);
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(primeiro)].Thumbnail.Path != imagemIndisponivel)
                    {
                        continua = false;
                    }
                } while (continua);
                continua = true;
            }

            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(segundo)].Thumbnail.Path == imagemIndisponivel)
            {
                do
                {
                    segundo = rdn.Next(20, 39);
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(segundo)].Thumbnail.Path != imagemIndisponivel)
                    {
                        continua = false;
                    }
                } while (continua);
                continua = true;
            }

            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(terceiro)].Thumbnail.Path == imagemIndisponivel)
            {
                do
                {
                    terceiro = rdn.Next(40, 59);
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(terceiro)].Thumbnail.Path != imagemIndisponivel)
                    {
                        continua = false;
                    }
                } while (continua);
                continua = true;
            }

            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(quarto)].Thumbnail.Path == imagemIndisponivel)
            {
                do
                {
                    quarto = rdn.Next(60, 79);
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(quarto)].Thumbnail.Path != imagemIndisponivel)
                    {
                        continua = false;
                    }
                } while (continua);
                continua = true;
            }

            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(quinto)].Thumbnail.Path == imagemIndisponivel)
            {
                do
                {
                    quinto = rdn.Next(80, 99);
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32(quinto)].Thumbnail.Path != imagemIndisponivel)
                    {
                        continua = false;
                    }
                } while (continua);
                continua = true;
            }
            Quadrinhos = new ObservableCollection<StackLayoutClass>
                {
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(primeiro)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(primeiro)].Thumbnail.Extension},
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(segundo)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(segundo)].Thumbnail.Extension},
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(terceiro)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(terceiro)].Thumbnail.Extension},
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(quarto)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(quarto)].Thumbnail.Extension},
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(quinto)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(quinto)].Thumbnail.Extension}
                };
        }
        public ObservableCollection<StackLayoutClass> Quadrinhos { get; set; }
    }



    public class DetalhesViewModel
    {
        public DetalhesViewModel(int tipo)
        {
            if (tipo == 1)
            {
                if (MainPage.quadrinhos.Datas.Results.Count > (DetalhesDaPagina.offset_Quadrinhos))
                {

                    //Quadrinhos
                    for (int i = DetalhesDaPagina.offset_Quadrinhos; i < (DetalhesDaPagina.offset_Quadrinhos + 15); i++)
                    {

                        Detalhes.Add(new DetalhesClass() { Detalhe = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(i)].Title, ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(i)].Thumbnail.Path + "." + MainPage.quadrinhos.Datas.Results[Convert.ToInt32(i)].Thumbnail.Extension });

                    }
                }
                else
                {
                    DependencyService.Get<Interfaces.IMessage>().LongAlert("Ainda não disponivel");
                }
            }
            else
            {
                if (MainPage.personagens.Data.Results.Count > DetalhesDaPagina.offset_Personagens)
                {
                    //Personagens
                    for (int i = DetalhesDaPagina.offset_Personagens; i < (DetalhesDaPagina.offset_Personagens + 15); i++)
                    {

                        Detalhes.Add(new DetalhesClass() { Detalhe = MainPage.personagens.Data.Results[Convert.ToInt32(i)].Name, ImagemUrl = MainPage.personagens.Data.Results[Convert.ToInt32(i)].Thumbnail.Path + "." + MainPage.personagens.Data.Results[Convert.ToInt32(i)].Thumbnail.Extension });

                    }
                }
                else
                {
                    string result;
                    string url = ConstantesChaves.url_fixa + "characters?limit=100&ts=" + ConstantesChaves.timestamp + "&apikey=" + ConstantesChaves.chave_publica + "&hash=" + ConstantesChaves.hash;
                    HttpWebRequest request1;
                    request1 = (HttpWebRequest)WebRequest.Create(url);
                    request1.Headers.Clear();
                    request1.ContentType = "application/json";
                    request1.Method = "GET";
                    WebResponse retorno1 = request1.GetResponse();

                    using (Stream stream1 = request1.GetResponse().GetResponseStream())
                    {
                        StreamReader reader1 = new StreamReader(stream1, Encoding.UTF8);

                        result = reader1.ReadToEnd();
                    }

                }
            }


        }
        public ObservableCollection<DetalhesClass> Detalhes = new ObservableCollection<DetalhesClass>();
        public ObservableCollection<DetalhesClass> Detalhes1 { get { return Detalhes; } set { Detalhes = value; } }
    }

}