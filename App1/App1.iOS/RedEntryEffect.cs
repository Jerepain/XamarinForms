using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App1.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ResolutionGroupName("App1")]
[assembly: ExportEffect(typeof(RedEntryEffect), "RedEntryEffect")]
namespace App1.iOS
{
    class RedEntryEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var entry = Control as UITextField;
            if (entry != null)
            {

                entry.Layer.BorderWidth = 2;
                entry.Layer.BorderColor = Color.Red.ToCGColor();
            }
        }

        protected override void OnDetached()
        {

        }
    }
}