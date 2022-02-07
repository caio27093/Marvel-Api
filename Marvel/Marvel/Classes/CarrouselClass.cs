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
        public StackLayoutViewModel()
        {

            Quadrinhos = new ObservableCollection<StackLayoutClass>
                {
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.primeiro)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.primeiro)].Thumbnail.Extension},
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.segundo)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.segundo)].Thumbnail.Extension},
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.terceiro)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.terceiro)].Thumbnail.Extension},
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.quarto)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.quarto)].Thumbnail.Extension},
                    new StackLayoutClass {Detalhe = "a",ImagemUrl = MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.quinto)].Thumbnail.Path+"."+MainPage.quadrinhos.Datas.Results[Convert.ToInt32(MainPage.quinto)].Thumbnail.Extension}
                };
        }
        public ObservableCollection<StackLayoutClass> Quadrinhos { get; set; }
    }
}
