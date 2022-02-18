using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Marvel.Interfaces;
using Marvel.Droid;
using Android.Content.Res;
using System.IO;

[assembly: Xamarin.Forms.Dependency ( typeof ( MessageAndroid ) )]
namespace Marvel.Droid
{
    public class MessageAndroid : IMessage
    {
        public static string comics;
        public static string heroes;
        public void LongAlert ( string message )
        {
            Toast.MakeText ( Application.Context, message, ToastLength.Long ).Show ( );
        }
        public string PegaJson()
        {
            return comics;
        }

        public string PegaJsonPersonagens()
        {
            return heroes;
        }
        public void ShortAlert ( string message )
        {
            Toast.MakeText ( Application.Context, message, ToastLength.Short ).Show ( );
        }
    }
}