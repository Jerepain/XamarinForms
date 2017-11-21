
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
  //  [ContentProperty("InnerContent")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FieldsetView :ContentView
    {

        //public static readonly BindableProperty InnerContentProperty =
        //    BindableProperty.Create("InnerContent", typeof(object), typeof(FieldsetView));

        //public object InnerContent
        //{
        //    get { return (object)GetValue(InnerContentProperty); }
        //    set { SetValue(InnerContentProperty, value); }
        //}

        public static readonly BindableProperty HeaderProperty = BindableProperty.Create(
            "Header",
            typeof(string),
            typeof(FieldsetView),
            null);

        public string Header { get { return (string)GetValue(HeaderProperty); } set { SetValue(HeaderProperty, value); } }

    

        //public static readonly BindableProperty ContentProperty = BindableProperty.Create(
        //    "Content",
        //    typeof(ContentPresenter),
        //    typeof(FieldsetView),
        //    null);

        //public string Content { get { return (string)GetValue(ContentProperty); } set { SetValue(ContentProperty, value); } }








        public FieldsetView()
        {
            InitializeComponent();
            //content.BindingContext = this;
        }
    }
}