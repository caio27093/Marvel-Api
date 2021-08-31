using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Marvel.Renders;
using Xamarin.Forms.Platform.Android;
using Android.Content.Res;
using Android.Graphics;
using Marvel.Droid.Render;

[assembly: ExportRenderer ( typeof ( ExtenderEntry ), typeof ( ExtenderEntryRender ) )]
namespace Marvel.Droid.Render
{
    public class ExtenderEntryRender : EntryRenderer
    {

        public ExtenderEntryRender ( Context context ) : base ( context )
        {

        }

        protected override void OnElementChanged ( ElementChangedEventArgs<Entry> e )
        {

            base.OnElementChanged ( e );

            if (Control == null || e.NewElement == null) return;

            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop)
            {
                Control.BackgroundTintList = ColorStateList.ValueOf ( Android.Graphics.Color.Transparent );
            }
            else
            {
                Control.Background.SetColorFilter ( Android.Graphics.Color.Transparent, PorterDuff.Mode.SrcAtop );

            }
        }
    }
}