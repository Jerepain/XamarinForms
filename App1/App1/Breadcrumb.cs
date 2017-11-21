using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1
{
    public class Breadcrumb : ContentView
    {

        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(
            nameof(ItemsSource),
            typeof(IEnumerable),
            typeof(Breadcrumb), null, BindingMode.Default, null, OnItemsSourcePropertyChanged);
        public ObservableCollection<BreadCrumbItem> ItemsSource
        {

            get
            {
                return (ObservableCollection<BreadCrumbItem>)GetValue(ItemsSourceProperty);
            }
            set
            {
                SetValue(ItemsSourceProperty, value);
            }
        }



        public static readonly BindableProperty CommandProperty = BindableProperty.Create<Breadcrumb, ICommand>(p => p.Command, null);
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public Breadcrumb()
        {

        }



        private static void OnItemsSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = bindable as Breadcrumb;
            control?.OnItemsSourceChanged(oldValue, newValue);
        }

        private void OnItemsSourceChanged(object oldValue, object newValue)
        {
            var breadCrumbItems = (IEnumerable<BreadCrumbItem>)newValue;
            if (breadCrumbItems == null || !breadCrumbItems.Any()) return;
            var content = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label
                    {
                        Text = "Site",
                        GestureRecognizers = {new TapGestureRecognizer(x => Command.Execute("Site"))}
                    }
                }

            };

            foreach (var item in breadCrumbItems)
            {
                content.Children.Add(new Label
                {
                    Text = " > " + item.Label,
                    GestureRecognizers = { new TapGestureRecognizer(x => Command.Execute(item.Label)) }
                });
                //content.Children.Add(new Label { Text = " > " + item.Label, GestureRecognizers = { new TapGestureRecognizer(TappedCallback) } });
            }

            Content = content;
        }


        private static void TappedCallback(View arg1, object arg2)
        {
            var item = (Label)arg1;

            //lancer bindable property commande 
            //if (Command != null && Command.CanExecute(null))
            //{
            //    Command.Execute(null);
            //}
        }


    }
}