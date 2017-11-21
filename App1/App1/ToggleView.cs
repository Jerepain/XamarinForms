using Xamarin.Forms;

namespace App1
{
    public class ToggleView : ContentView
    {
        private Image ToggleImage;

        public ToggleView()
        {
            ToggleImage = new Image
            {
                Source = ImageSource.FromResource("App1.fleche-expander.png")
            };

            this.Content = ToggleImage;

            this.GestureRecognizers.Add(new TapGestureRecognizer(TappedCallback));
        }

        private void TappedCallback(View view)
        {
            if (Expanded)
            {
                ToggleImage.Source = ImageSource.FromResource("App1.fleche-expander.png");
                Expanded = false;
            }
            else
            {
                ToggleImage.Source = ImageSource.FromResource("App1.fleche-expander-bas.png");
                Expanded = true;
                
            }
        }

        public static readonly BindableProperty CheckedProperty =
            BindableProperty.Create<ToggleView, bool>(p => p.Expanded, false);

        public bool Expanded
        {
            get { return (bool) base.GetValue(CheckedProperty); }
            set { base.SetValue(CheckedProperty, value); }
        }
    }
}
