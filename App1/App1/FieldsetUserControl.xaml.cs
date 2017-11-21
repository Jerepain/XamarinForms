
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FieldsetUserControl : ContentView
    {
        public FieldsetUserControl()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty HeaderProperty = BindableProperty.Create(
            "Header",
            typeof(string),
            typeof(FieldsetUserControl),
            null);

        public string Header { get { return (string)GetValue(HeaderProperty); } set { SetValue(HeaderProperty, value); } }
    }
}