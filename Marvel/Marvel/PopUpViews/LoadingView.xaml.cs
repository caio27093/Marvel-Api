using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Marvel.PopUpViews
{
    [XamlCompilation ( XamlCompilationOptions.Compile )]
    public partial class LoadingView : PopupPage
    {
        public LoadingView ( )
        {
            InitializeComponent ( );
        }
    }
}