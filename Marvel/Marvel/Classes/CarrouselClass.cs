using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

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
    public class StackLayoutViewModel
    {

        public int primeiro;
        public int segundo;
        public int terceiro;
        public int quarto;
        public int quinto;
        public StackLayoutViewModel()
        {
            Random rdn = new Random ( );
            primeiro = rdn.Next ( 0, 19 );
            segundo = rdn.Next ( 20, 39 );
            terceiro = rdn.Next ( 40, 59 );
            quarto = rdn.Next ( 60, 79 );
            quinto = rdn.Next ( 80, 99 );
            bool continua = true;
            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( primeiro )].Thumbnail.Path == "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
            {
                do
                {
                    primeiro = rdn.Next ( 0, 19 );
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( primeiro )].Thumbnail.Path != "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
                    {
                        continua = false;
                    }
                } while (continua);
                continua = true;
            }

            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( segundo )].Thumbnail.Path == "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
            {
                do
                {
                    segundo = rdn.Next ( 20, 39 );
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( segundo )].Thumbnail.Path != "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
                    {
                        continua = false;
                    }
                } while (continua);
                continua = true;
            }

            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( terceiro )].Thumbnail.Path == "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
            {
                do
                {
                    terceiro = rdn.Next ( 40, 59 );
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( terceiro )].Thumbnail.Path != "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
                    {
                        continua = false;
                    }
                } while (continua);
                continua = true;
            }

            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( quarto )].Thumbnail.Path == "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
            {
                do
                {
                    quarto = rdn.Next ( 60, 79 );
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( quarto )].Thumbnail.Path != "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
                    {
                        continua = false;
                    }
                } while (continua);
                continua = true;
            }

            if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( quinto )].Thumbnail.Path == "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
            {
                do
                {
                    quinto = rdn.Next ( 80, 99 );
                    if (MainPage.quadrinhos.Datas.Results[Convert.ToInt32 ( quinto )].Thumbnail.Path != "http://i.annihil.us/u/prod/marvel/i/mg/b/40/image_not_available")
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
}
