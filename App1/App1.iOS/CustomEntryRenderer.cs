using App1;
using App1.iOS;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]

namespace App1.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null) return;
            Control.Layer.BorderWidth = 1;
            Control.Layer.BorderColor = Color.DarkGray.ToCGColor();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged( sender,  e);
            if (Control == null) return;
            Control.Layer.BorderColor = string.IsNullOrEmpty(Control.Text) ? Color.Red.ToCGColor() : Color.DarkGray.ToCGColor();
        }
    }
}